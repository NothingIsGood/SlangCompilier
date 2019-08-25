﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLangCompiler.Exceptions;

namespace SLangCompiler.FileServices
{
    /// <summary>
    /// Loads source code
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Source code container
        /// </summary>
        public readonly Dictionary<string, ModuleData> FileModules = new Dictionary<string, ModuleData>();

        /// <summary>
        /// Load source code from Lib folder and user directory
        /// </summary>
        /// <param name="directory">user soucre code directory</param>
        public async void LoadCode(DirectoryInfo directory)
        {
            if (!directory.Exists)
                throw new DirectoryNotFoundException($"Directory \"{directory.FullName}\" not found");

            await LoadLibrary();

            IEnumerable<FileInfo> inputFiles =
                directory.GetFiles(CompilerConstants.FileMask, SearchOption.TopDirectoryOnly);

            foreach (FileInfo inputFile in inputFiles.AsParallel())
            {
                ModuleData module = await LoadModuleFile(inputFile, false);

                if (FileModules.ContainsKey(module.Name))
                {
                    throw new FileAlreadyExistsException($"Module \"{module.Name}\" cannot be named as system module.");
                }

                FileModules.Add(module.Name, module);
            }
        }
        /// <summary>
        /// Check main module contains in project
        /// </summary>
        /// <returns></returns>
        public bool ContainsMainModule() => FileModules.ContainsKey(CompilerConstants.MainModuleName);
        /// <summary>
        /// Load code from Lib folder
        /// </summary>
        /// <returns></returns>
        public async Task LoadLibrary()
        {
            DirectoryInfo inputDirectory = new DirectoryInfo(CompilerConstants.LibPath);

            IEnumerable<FileInfo> inputFiles =
                inputDirectory.GetFiles(CompilerConstants.FileMask, SearchOption.TopDirectoryOnly);

            foreach (FileInfo inputFile in inputFiles.AsParallel())
            {
                ModuleData module = await LoadModuleFile(inputFile, true);
                FileModules.Add(module.Name, module);
            }
        }
        /// <summary>
        /// Loads single file
        /// </summary>
        /// <param name="file">File data</param>
        /// <param name="isLib">Check file is in Lib folder</param>
        /// <returns></returns>
        public async Task<ModuleData> LoadModuleFile(FileInfo file, bool isLib)
        {
            string nameOfModule = Path.GetFileNameWithoutExtension(file.FullName);
            string code;

            using (TextReader reader = file.OpenText())
            {
                code = await reader.ReadToEndAsync();
            }
            return new ModuleData(nameOfModule, file, code, isLib);
        }

    }
}