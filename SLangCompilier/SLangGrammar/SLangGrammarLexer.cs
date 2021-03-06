//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.5
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from SLangGrammar.g4 by ANTLR 4.6.5

// Unreachable code detected

using System;
using System.CodeDom.Compiler;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SLangGrammar {
    [GeneratedCode("ANTLR", "4.6.5")]
[CLSCompliant(false)]
public partial class SLangGrammarLexer : Lexer {
	public const int
		SimpleType=1, AddOp=2, SubOp=3, MulOp=4, DivOp=5, ModOp=6, BoolOr=7, BoolAnd=8, 
		BoolEq=9, BoolNeq=10, BoolG=11, BoolL=12, BoolGeq=13, BoolLeq=14, BoolNot=15, 
		Colon=16, Semicolon=17, Comma=18, Point=19, Variable=20, Const=21, Let=22, 
		Return=23, Input=24, Output=25, Call=26, If=27, Then=28, Else=29, While=30, 
		Repeat=31, Elseif=32, Do=33, Module=34, Import=35, Start=36, End=37, Function=38, 
		Procedure=39, LBrace=40, RBrace=41, LSBrace=42, RSBrace=43, Assign=44, 
		New=45, Nil=46, Pointer=47, Array=48, FunctionArgModifier=49, AccessModifier=50, 
		Class=51, Empty=52, Inherit=53, Base=54, Abstract=55, Override=56, From=57, 
		IntValue=58, RealValue=59, BoolValue=60, Id=61, StringLiteral=62, SingleCharacter=63, 
		Comment=64, Ws=65;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"SimpleType", "AddOp", "SubOp", "MulOp", "DivOp", "ModOp", "BoolOr", "BoolAnd", 
		"BoolEq", "BoolNeq", "BoolG", "BoolL", "BoolGeq", "BoolLeq", "BoolNot", 
		"Colon", "Semicolon", "Comma", "Point", "Variable", "Const", "Let", "Return", 
		"Input", "Output", "Call", "If", "Then", "Else", "While", "Repeat", "Elseif", 
		"Do", "Module", "Import", "Start", "End", "Function", "Procedure", "LBrace", 
		"RBrace", "LSBrace", "RSBrace", "Assign", "Integer", "Real", "Character", 
		"Boolean", "String", "New", "Nil", "Pointer", "Array", "FunctionArgModifier", 
		"ArgValModifier", "ArgRefModifier", "AccessModifier", "PublicModifier", 
		"PrivateModifier", "Class", "Empty", "Inherit", "Base", "Abstract", "Override", 
		"From", "Digit", "IntValue", "RealValue", "BoolValue", "Id", "StringLiteral", 
		"SingleCharacter", "StringCharacter", "EscapeSequence", "Comment", "Ws"
	};


	public SLangGrammarLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'+'", "'-'", "'*'", "'/'", "'%'", "'||'", "'&&'", "'=='", 
		"'!='", "'>'", "'<'", "'>='", "'<='", "'!'", "':'", "';'", "','", "'.'", 
		"'variable'", "'const'", "'let'", "'return'", "'input'", "'output'", "'call'", 
		"'if'", "'then'", "'else'", "'while'", "'repeat'", "'elseif'", "'do'", 
		"'module'", "'import'", "'start'", "'end'", "'function'", "'procedure'", 
		"'('", "')'", "'['", "']'", "':='", "'new'", "'nil'", "'pointer'", "'array'", 
		null, null, "'class'", "'empty'", "'inherit'", "'base'", "'abstract'", 
		"'override'", "'from'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SimpleType", "AddOp", "SubOp", "MulOp", "DivOp", "ModOp", "BoolOr", 
		"BoolAnd", "BoolEq", "BoolNeq", "BoolG", "BoolL", "BoolGeq", "BoolLeq", 
		"BoolNot", "Colon", "Semicolon", "Comma", "Point", "Variable", "Const", 
		"Let", "Return", "Input", "Output", "Call", "If", "Then", "Else", "While", 
		"Repeat", "Elseif", "Do", "Module", "Import", "Start", "End", "Function", 
		"Procedure", "LBrace", "RBrace", "LSBrace", "RSBrace", "Assign", "New", 
		"Nil", "Pointer", "Array", "FunctionArgModifier", "AccessModifier", "Class", 
		"Empty", "Inherit", "Base", "Abstract", "Override", "From", "IntValue", 
		"RealValue", "BoolValue", "Id", "StringLiteral", "SingleCharacter", "Comment", 
		"Ws"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "SLangGrammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x43\x241\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t"+
		")\x4*\t*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31"+
		"\x4\x32\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37"+
		"\t\x37\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4"+
		"?\t?\x4@\t@\x4\x41\t\x41\x4\x42\t\x42\x4\x43\t\x43\x4\x44\t\x44\x4\x45"+
		"\t\x45\x4\x46\t\x46\x4G\tG\x4H\tH\x4I\tI\x4J\tJ\x4K\tK\x4L\tL\x4M\tM\x4"+
		"N\tN\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x5\x2\xA3\n\x2\x3\x3\x3\x3\x3\x4\x3"+
		"\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\t\x3\t\x3\t\x3"+
		"\n\x3\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xF"+
		"\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3"+
		"\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3\x15\x3"+
		"\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3"+
		"\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3"+
		"\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3"+
		"\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3"+
		"!\x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3$\x3$\x3"+
		"$\x3$\x3$\x3$\x3$\x3%\x3%\x3%\x3%\x3%\x3%\x3&\x3&\x3&\x3&\x3\'\x3\'\x3"+
		"\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3(\x3"+
		"(\x3)\x3)\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3-\x3.\x3.\x3.\x3.\x3.\x3."+
		"\x3.\x3.\x3/\x3/\x3/\x3/\x3/\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30\x3\x30"+
		"\x3\x30\x3\x30\x3\x30\x3\x30\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31\x3\x31"+
		"\x3\x31\x3\x31\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x32\x3\x33"+
		"\x3\x33\x3\x33\x3\x33\x3\x34\x3\x34\x3\x34\x3\x34\x3\x35\x3\x35\x3\x35"+
		"\x3\x35\x3\x35\x3\x35\x3\x35\x3\x35\x3\x36\x3\x36\x3\x36\x3\x36\x3\x36"+
		"\x3\x36\x3\x37\x3\x37\x5\x37\x193\n\x37\x3\x38\x3\x38\x3\x38\x3\x38\x3"+
		"\x39\x3\x39\x3\x39\x3\x39\x3:\x3:\x5:\x19F\n:\x3;\x3;\x3;\x3;\x3;\x3;"+
		"\x3;\x3<\x3<\x3<\x3<\x3<\x3<\x3<\x3<\x3=\x3=\x3=\x3=\x3=\x3=\x3>\x3>\x3"+
		">\x3>\x3>\x3>\x3?\x3?\x3?\x3?\x3?\x3?\x3?\x3?\x3@\x3@\x3@\x3@\x3@\x3\x41"+
		"\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x41\x3\x42\x3\x42"+
		"\x3\x42\x3\x42\x3\x42\x3\x42\x3\x42\x3\x42\x3\x42\x3\x43\x3\x43\x3\x43"+
		"\x3\x43\x3\x43\x3\x44\x3\x44\x3\x45\x6\x45\x1E3\n\x45\r\x45\xE\x45\x1E4"+
		"\x3\x46\a\x46\x1E8\n\x46\f\x46\xE\x46\x1EB\v\x46\x3\x46\x5\x46\x1EE\n"+
		"\x46\x3\x46\x6\x46\x1F1\n\x46\r\x46\xE\x46\x1F2\x3\x46\x3\x46\x5\x46\x1F7"+
		"\n\x46\x3\x46\x6\x46\x1FA\n\x46\r\x46\xE\x46\x1FB\x5\x46\x1FE\n\x46\x3"+
		"G\x3G\x3G\x3G\x3G\x3G\x3G\x3G\x3G\x5G\x209\nG\x3H\x3H\aH\x20D\nH\fH\xE"+
		"H\x210\vH\x3I\x3I\aI\x214\nI\fI\xEI\x217\vI\x3I\x3I\x3J\x3J\x3J\x3J\x3"+
		"K\x3K\x5K\x221\nK\x3L\x3L\x3L\x3M\x3M\x3M\x3M\aM\x22A\nM\fM\xEM\x22D\v"+
		"M\x3M\x3M\x3M\x3M\aM\x233\nM\fM\xEM\x236\vM\x3M\x3M\x5M\x23A\nM\x3M\x3"+
		"M\x3N\x3N\x3N\x3N\x3\x234\x2\x2O\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2"+
		"\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2"+
		"\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2"+
		"\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2"+
		"\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O"+
		"\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.[\x2\x2]\x2\x2_\x2\x2\x61\x2\x2\x63\x2\x2"+
		"\x65\x2/g\x2\x30i\x2\x31k\x2\x32m\x2\x33o\x2\x2q\x2\x2s\x2\x34u\x2\x2"+
		"w\x2\x2y\x2\x35{\x2\x36}\x2\x37\x7F\x2\x38\x81\x2\x39\x83\x2:\x85\x2;"+
		"\x87\x2\x2\x89\x2<\x8B\x2=\x8D\x2>\x8F\x2?\x91\x2@\x93\x2\x41\x95\x2\x2"+
		"\x97\x2\x2\x99\x2\x42\x9B\x2\x43\x3\x2\v\x3\x2\x32;\x4\x2GGgg\x4\x2--"+
		"//\x5\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x3\x2$$\n\x2"+
		"$$))^^\x64\x64hhppttvv\x4\x2\f\f\xF\xF\x5\x2\v\f\xF\xF\"\"\x248\x2\x3"+
		"\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v"+
		"\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2"+
		"\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2"+
		"\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2"+
		"\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2"+
		"\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2"+
		"\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2"+
		"\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2"+
		"\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2"+
		"\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3"+
		"\x2\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x2\x65\x3\x2"+
		"\x2\x2\x2g\x3\x2\x2\x2\x2i\x3\x2\x2\x2\x2k\x3\x2\x2\x2\x2m\x3\x2\x2\x2"+
		"\x2s\x3\x2\x2\x2\x2y\x3\x2\x2\x2\x2{\x3\x2\x2\x2\x2}\x3\x2\x2\x2\x2\x7F"+
		"\x3\x2\x2\x2\x2\x81\x3\x2\x2\x2\x2\x83\x3\x2\x2\x2\x2\x85\x3\x2\x2\x2"+
		"\x2\x89\x3\x2\x2\x2\x2\x8B\x3\x2\x2\x2\x2\x8D\x3\x2\x2\x2\x2\x8F\x3\x2"+
		"\x2\x2\x2\x91\x3\x2\x2\x2\x2\x93\x3\x2\x2\x2\x2\x99\x3\x2\x2\x2\x2\x9B"+
		"\x3\x2\x2\x2\x3\xA2\x3\x2\x2\x2\x5\xA4\x3\x2\x2\x2\a\xA6\x3\x2\x2\x2\t"+
		"\xA8\x3\x2\x2\x2\v\xAA\x3\x2\x2\x2\r\xAC\x3\x2\x2\x2\xF\xAE\x3\x2\x2\x2"+
		"\x11\xB1\x3\x2\x2\x2\x13\xB4\x3\x2\x2\x2\x15\xB7\x3\x2\x2\x2\x17\xBA\x3"+
		"\x2\x2\x2\x19\xBC\x3\x2\x2\x2\x1B\xBE\x3\x2\x2\x2\x1D\xC1\x3\x2\x2\x2"+
		"\x1F\xC4\x3\x2\x2\x2!\xC6\x3\x2\x2\x2#\xC8\x3\x2\x2\x2%\xCA\x3\x2\x2\x2"+
		"\'\xCC\x3\x2\x2\x2)\xCE\x3\x2\x2\x2+\xD7\x3\x2\x2\x2-\xDD\x3\x2\x2\x2"+
		"/\xE1\x3\x2\x2\x2\x31\xE8\x3\x2\x2\x2\x33\xEE\x3\x2\x2\x2\x35\xF5\x3\x2"+
		"\x2\x2\x37\xFA\x3\x2\x2\x2\x39\xFD\x3\x2\x2\x2;\x102\x3\x2\x2\x2=\x107"+
		"\x3\x2\x2\x2?\x10D\x3\x2\x2\x2\x41\x114\x3\x2\x2\x2\x43\x11B\x3\x2\x2"+
		"\x2\x45\x11E\x3\x2\x2\x2G\x125\x3\x2\x2\x2I\x12C\x3\x2\x2\x2K\x132\x3"+
		"\x2\x2\x2M\x136\x3\x2\x2\x2O\x13F\x3\x2\x2\x2Q\x149\x3\x2\x2\x2S\x14B"+
		"\x3\x2\x2\x2U\x14D\x3\x2\x2\x2W\x14F\x3\x2\x2\x2Y\x151\x3\x2\x2\x2[\x154"+
		"\x3\x2\x2\x2]\x15C\x3\x2\x2\x2_\x161\x3\x2\x2\x2\x61\x16B\x3\x2\x2\x2"+
		"\x63\x173\x3\x2\x2\x2\x65\x17A\x3\x2\x2\x2g\x17E\x3\x2\x2\x2i\x182\x3"+
		"\x2\x2\x2k\x18A\x3\x2\x2\x2m\x192\x3\x2\x2\x2o\x194\x3\x2\x2\x2q\x198"+
		"\x3\x2\x2\x2s\x19E\x3\x2\x2\x2u\x1A0\x3\x2\x2\x2w\x1A7\x3\x2\x2\x2y\x1AF"+
		"\x3\x2\x2\x2{\x1B5\x3\x2\x2\x2}\x1BB\x3\x2\x2\x2\x7F\x1C3\x3\x2\x2\x2"+
		"\x81\x1C8\x3\x2\x2\x2\x83\x1D1\x3\x2\x2\x2\x85\x1DA\x3\x2\x2\x2\x87\x1DF"+
		"\x3\x2\x2\x2\x89\x1E2\x3\x2\x2\x2\x8B\x1E9\x3\x2\x2\x2\x8D\x208\x3\x2"+
		"\x2\x2\x8F\x20A\x3\x2\x2\x2\x91\x211\x3\x2\x2\x2\x93\x21A\x3\x2\x2\x2"+
		"\x95\x220\x3\x2\x2\x2\x97\x222\x3\x2\x2\x2\x99\x239\x3\x2\x2\x2\x9B\x23D"+
		"\x3\x2\x2\x2\x9D\xA3\x5]/\x2\x9E\xA3\x5[.\x2\x9F\xA3\x5\x61\x31\x2\xA0"+
		"\xA3\x5_\x30\x2\xA1\xA3\x5\x63\x32\x2\xA2\x9D\x3\x2\x2\x2\xA2\x9E\x3\x2"+
		"\x2\x2\xA2\x9F\x3\x2\x2\x2\xA2\xA0\x3\x2\x2\x2\xA2\xA1\x3\x2\x2\x2\xA3"+
		"\x4\x3\x2\x2\x2\xA4\xA5\a-\x2\x2\xA5\x6\x3\x2\x2\x2\xA6\xA7\a/\x2\x2\xA7"+
		"\b\x3\x2\x2\x2\xA8\xA9\a,\x2\x2\xA9\n\x3\x2\x2\x2\xAA\xAB\a\x31\x2\x2"+
		"\xAB\f\x3\x2\x2\x2\xAC\xAD\a\'\x2\x2\xAD\xE\x3\x2\x2\x2\xAE\xAF\a~\x2"+
		"\x2\xAF\xB0\a~\x2\x2\xB0\x10\x3\x2\x2\x2\xB1\xB2\a(\x2\x2\xB2\xB3\a(\x2"+
		"\x2\xB3\x12\x3\x2\x2\x2\xB4\xB5\a?\x2\x2\xB5\xB6\a?\x2\x2\xB6\x14\x3\x2"+
		"\x2\x2\xB7\xB8\a#\x2\x2\xB8\xB9\a?\x2\x2\xB9\x16\x3\x2\x2\x2\xBA\xBB\a"+
		"@\x2\x2\xBB\x18\x3\x2\x2\x2\xBC\xBD\a>\x2\x2\xBD\x1A\x3\x2\x2\x2\xBE\xBF"+
		"\a@\x2\x2\xBF\xC0\a?\x2\x2\xC0\x1C\x3\x2\x2\x2\xC1\xC2\a>\x2\x2\xC2\xC3"+
		"\a?\x2\x2\xC3\x1E\x3\x2\x2\x2\xC4\xC5\a#\x2\x2\xC5 \x3\x2\x2\x2\xC6\xC7"+
		"\a<\x2\x2\xC7\"\x3\x2\x2\x2\xC8\xC9\a=\x2\x2\xC9$\x3\x2\x2\x2\xCA\xCB"+
		"\a.\x2\x2\xCB&\x3\x2\x2\x2\xCC\xCD\a\x30\x2\x2\xCD(\x3\x2\x2\x2\xCE\xCF"+
		"\ax\x2\x2\xCF\xD0\a\x63\x2\x2\xD0\xD1\at\x2\x2\xD1\xD2\ak\x2\x2\xD2\xD3"+
		"\a\x63\x2\x2\xD3\xD4\a\x64\x2\x2\xD4\xD5\an\x2\x2\xD5\xD6\ag\x2\x2\xD6"+
		"*\x3\x2\x2\x2\xD7\xD8\a\x65\x2\x2\xD8\xD9\aq\x2\x2\xD9\xDA\ap\x2\x2\xDA"+
		"\xDB\au\x2\x2\xDB\xDC\av\x2\x2\xDC,\x3\x2\x2\x2\xDD\xDE\an\x2\x2\xDE\xDF"+
		"\ag\x2\x2\xDF\xE0\av\x2\x2\xE0.\x3\x2\x2\x2\xE1\xE2\at\x2\x2\xE2\xE3\a"+
		"g\x2\x2\xE3\xE4\av\x2\x2\xE4\xE5\aw\x2\x2\xE5\xE6\at\x2\x2\xE6\xE7\ap"+
		"\x2\x2\xE7\x30\x3\x2\x2\x2\xE8\xE9\ak\x2\x2\xE9\xEA\ap\x2\x2\xEA\xEB\a"+
		"r\x2\x2\xEB\xEC\aw\x2\x2\xEC\xED\av\x2\x2\xED\x32\x3\x2\x2\x2\xEE\xEF"+
		"\aq\x2\x2\xEF\xF0\aw\x2\x2\xF0\xF1\av\x2\x2\xF1\xF2\ar\x2\x2\xF2\xF3\a"+
		"w\x2\x2\xF3\xF4\av\x2\x2\xF4\x34\x3\x2\x2\x2\xF5\xF6\a\x65\x2\x2\xF6\xF7"+
		"\a\x63\x2\x2\xF7\xF8\an\x2\x2\xF8\xF9\an\x2\x2\xF9\x36\x3\x2\x2\x2\xFA"+
		"\xFB\ak\x2\x2\xFB\xFC\ah\x2\x2\xFC\x38\x3\x2\x2\x2\xFD\xFE\av\x2\x2\xFE"+
		"\xFF\aj\x2\x2\xFF\x100\ag\x2\x2\x100\x101\ap\x2\x2\x101:\x3\x2\x2\x2\x102"+
		"\x103\ag\x2\x2\x103\x104\an\x2\x2\x104\x105\au\x2\x2\x105\x106\ag\x2\x2"+
		"\x106<\x3\x2\x2\x2\x107\x108\ay\x2\x2\x108\x109\aj\x2\x2\x109\x10A\ak"+
		"\x2\x2\x10A\x10B\an\x2\x2\x10B\x10C\ag\x2\x2\x10C>\x3\x2\x2\x2\x10D\x10E"+
		"\at\x2\x2\x10E\x10F\ag\x2\x2\x10F\x110\ar\x2\x2\x110\x111\ag\x2\x2\x111"+
		"\x112\a\x63\x2\x2\x112\x113\av\x2\x2\x113@\x3\x2\x2\x2\x114\x115\ag\x2"+
		"\x2\x115\x116\an\x2\x2\x116\x117\au\x2\x2\x117\x118\ag\x2\x2\x118\x119"+
		"\ak\x2\x2\x119\x11A\ah\x2\x2\x11A\x42\x3\x2\x2\x2\x11B\x11C\a\x66\x2\x2"+
		"\x11C\x11D\aq\x2\x2\x11D\x44\x3\x2\x2\x2\x11E\x11F\ao\x2\x2\x11F\x120"+
		"\aq\x2\x2\x120\x121\a\x66\x2\x2\x121\x122\aw\x2\x2\x122\x123\an\x2\x2"+
		"\x123\x124\ag\x2\x2\x124\x46\x3\x2\x2\x2\x125\x126\ak\x2\x2\x126\x127"+
		"\ao\x2\x2\x127\x128\ar\x2\x2\x128\x129\aq\x2\x2\x129\x12A\at\x2\x2\x12A"+
		"\x12B\av\x2\x2\x12BH\x3\x2\x2\x2\x12C\x12D\au\x2\x2\x12D\x12E\av\x2\x2"+
		"\x12E\x12F\a\x63\x2\x2\x12F\x130\at\x2\x2\x130\x131\av\x2\x2\x131J\x3"+
		"\x2\x2\x2\x132\x133\ag\x2\x2\x133\x134\ap\x2\x2\x134\x135\a\x66\x2\x2"+
		"\x135L\x3\x2\x2\x2\x136\x137\ah\x2\x2\x137\x138\aw\x2\x2\x138\x139\ap"+
		"\x2\x2\x139\x13A\a\x65\x2\x2\x13A\x13B\av\x2\x2\x13B\x13C\ak\x2\x2\x13C"+
		"\x13D\aq\x2\x2\x13D\x13E\ap\x2\x2\x13EN\x3\x2\x2\x2\x13F\x140\ar\x2\x2"+
		"\x140\x141\at\x2\x2\x141\x142\aq\x2\x2\x142\x143\a\x65\x2\x2\x143\x144"+
		"\ag\x2\x2\x144\x145\a\x66\x2\x2\x145\x146\aw\x2\x2\x146\x147\at\x2\x2"+
		"\x147\x148\ag\x2\x2\x148P\x3\x2\x2\x2\x149\x14A\a*\x2\x2\x14AR\x3\x2\x2"+
		"\x2\x14B\x14C\a+\x2\x2\x14CT\x3\x2\x2\x2\x14D\x14E\a]\x2\x2\x14EV\x3\x2"+
		"\x2\x2\x14F\x150\a_\x2\x2\x150X\x3\x2\x2\x2\x151\x152\a<\x2\x2\x152\x153"+
		"\a?\x2\x2\x153Z\x3\x2\x2\x2\x154\x155\ak\x2\x2\x155\x156\ap\x2\x2\x156"+
		"\x157\av\x2\x2\x157\x158\ag\x2\x2\x158\x159\ai\x2\x2\x159\x15A\ag\x2\x2"+
		"\x15A\x15B\at\x2\x2\x15B\\\x3\x2\x2\x2\x15C\x15D\at\x2\x2\x15D\x15E\a"+
		"g\x2\x2\x15E\x15F\a\x63\x2\x2\x15F\x160\an\x2\x2\x160^\x3\x2\x2\x2\x161"+
		"\x162\a\x65\x2\x2\x162\x163\aj\x2\x2\x163\x164\a\x63\x2\x2\x164\x165\a"+
		"t\x2\x2\x165\x166\a\x63\x2\x2\x166\x167\a\x65\x2\x2\x167\x168\av\x2\x2"+
		"\x168\x169\ag\x2\x2\x169\x16A\at\x2\x2\x16A`\x3\x2\x2\x2\x16B\x16C\a\x64"+
		"\x2\x2\x16C\x16D\aq\x2\x2\x16D\x16E\aq\x2\x2\x16E\x16F\an\x2\x2\x16F\x170"+
		"\ag\x2\x2\x170\x171\a\x63\x2\x2\x171\x172\ap\x2\x2\x172\x62\x3\x2\x2\x2"+
		"\x173\x174\au\x2\x2\x174\x175\av\x2\x2\x175\x176\at\x2\x2\x176\x177\a"+
		"k\x2\x2\x177\x178\ap\x2\x2\x178\x179\ai\x2\x2\x179\x64\x3\x2\x2\x2\x17A"+
		"\x17B\ap\x2\x2\x17B\x17C\ag\x2\x2\x17C\x17D\ay\x2\x2\x17D\x66\x3\x2\x2"+
		"\x2\x17E\x17F\ap\x2\x2\x17F\x180\ak\x2\x2\x180\x181\an\x2\x2\x181h\x3"+
		"\x2\x2\x2\x182\x183\ar\x2\x2\x183\x184\aq\x2\x2\x184\x185\ak\x2\x2\x185"+
		"\x186\ap\x2\x2\x186\x187\av\x2\x2\x187\x188\ag\x2\x2\x188\x189\at\x2\x2"+
		"\x189j\x3\x2\x2\x2\x18A\x18B\a\x63\x2\x2\x18B\x18C\at\x2\x2\x18C\x18D"+
		"\at\x2\x2\x18D\x18E\a\x63\x2\x2\x18E\x18F\a{\x2\x2\x18Fl\x3\x2\x2\x2\x190"+
		"\x193\x5o\x38\x2\x191\x193\x5q\x39\x2\x192\x190\x3\x2\x2\x2\x192\x191"+
		"\x3\x2\x2\x2\x193n\x3\x2\x2\x2\x194\x195\ax\x2\x2\x195\x196\a\x63\x2\x2"+
		"\x196\x197\an\x2\x2\x197p\x3\x2\x2\x2\x198\x199\at\x2\x2\x199\x19A\ag"+
		"\x2\x2\x19A\x19B\ah\x2\x2\x19Br\x3\x2\x2\x2\x19C\x19F\x5u;\x2\x19D\x19F"+
		"\x5w<\x2\x19E\x19C\x3\x2\x2\x2\x19E\x19D\x3\x2\x2\x2\x19Ft\x3\x2\x2\x2"+
		"\x1A0\x1A1\ar\x2\x2\x1A1\x1A2\aw\x2\x2\x1A2\x1A3\a\x64\x2\x2\x1A3\x1A4"+
		"\an\x2\x2\x1A4\x1A5\ak\x2\x2\x1A5\x1A6\a\x65\x2\x2\x1A6v\x3\x2\x2\x2\x1A7"+
		"\x1A8\ar\x2\x2\x1A8\x1A9\at\x2\x2\x1A9\x1AA\ak\x2\x2\x1AA\x1AB\ax\x2\x2"+
		"\x1AB\x1AC\a\x63\x2\x2\x1AC\x1AD\av\x2\x2\x1AD\x1AE\ag\x2\x2\x1AEx\x3"+
		"\x2\x2\x2\x1AF\x1B0\a\x65\x2\x2\x1B0\x1B1\an\x2\x2\x1B1\x1B2\a\x63\x2"+
		"\x2\x1B2\x1B3\au\x2\x2\x1B3\x1B4\au\x2\x2\x1B4z\x3\x2\x2\x2\x1B5\x1B6"+
		"\ag\x2\x2\x1B6\x1B7\ao\x2\x2\x1B7\x1B8\ar\x2\x2\x1B8\x1B9\av\x2\x2\x1B9"+
		"\x1BA\a{\x2\x2\x1BA|\x3\x2\x2\x2\x1BB\x1BC\ak\x2\x2\x1BC\x1BD\ap\x2\x2"+
		"\x1BD\x1BE\aj\x2\x2\x1BE\x1BF\ag\x2\x2\x1BF\x1C0\at\x2\x2\x1C0\x1C1\a"+
		"k\x2\x2\x1C1\x1C2\av\x2\x2\x1C2~\x3\x2\x2\x2\x1C3\x1C4\a\x64\x2\x2\x1C4"+
		"\x1C5\a\x63\x2\x2\x1C5\x1C6\au\x2\x2\x1C6\x1C7\ag\x2\x2\x1C7\x80\x3\x2"+
		"\x2\x2\x1C8\x1C9\a\x63\x2\x2\x1C9\x1CA\a\x64\x2\x2\x1CA\x1CB\au\x2\x2"+
		"\x1CB\x1CC\av\x2\x2\x1CC\x1CD\at\x2\x2\x1CD\x1CE\a\x63\x2\x2\x1CE\x1CF"+
		"\a\x65\x2\x2\x1CF\x1D0\av\x2\x2\x1D0\x82\x3\x2\x2\x2\x1D1\x1D2\aq\x2\x2"+
		"\x1D2\x1D3\ax\x2\x2\x1D3\x1D4\ag\x2\x2\x1D4\x1D5\at\x2\x2\x1D5\x1D6\a"+
		"t\x2\x2\x1D6\x1D7\ak\x2\x2\x1D7\x1D8\a\x66\x2\x2\x1D8\x1D9\ag\x2\x2\x1D9"+
		"\x84\x3\x2\x2\x2\x1DA\x1DB\ah\x2\x2\x1DB\x1DC\at\x2\x2\x1DC\x1DD\aq\x2"+
		"\x2\x1DD\x1DE\ao\x2\x2\x1DE\x86\x3\x2\x2\x2\x1DF\x1E0\t\x2\x2\x2\x1E0"+
		"\x88\x3\x2\x2\x2\x1E1\x1E3\x5\x87\x44\x2\x1E2\x1E1\x3\x2\x2\x2\x1E3\x1E4"+
		"\x3\x2\x2\x2\x1E4\x1E2\x3\x2\x2\x2\x1E4\x1E5\x3\x2\x2\x2\x1E5\x8A\x3\x2"+
		"\x2\x2\x1E6\x1E8\x5\x87\x44\x2\x1E7\x1E6\x3\x2\x2\x2\x1E8\x1EB\x3\x2\x2"+
		"\x2\x1E9\x1E7\x3\x2\x2\x2\x1E9\x1EA\x3\x2\x2\x2\x1EA\x1ED\x3\x2\x2\x2"+
		"\x1EB\x1E9\x3\x2\x2\x2\x1EC\x1EE\x5\'\x14\x2\x1ED\x1EC\x3\x2\x2\x2\x1ED"+
		"\x1EE\x3\x2\x2\x2\x1EE\x1F0\x3\x2\x2\x2\x1EF\x1F1\x5\x87\x44\x2\x1F0\x1EF"+
		"\x3\x2\x2\x2\x1F1\x1F2\x3\x2\x2\x2\x1F2\x1F0\x3\x2\x2\x2\x1F2\x1F3\x3"+
		"\x2\x2\x2\x1F3\x1FD\x3\x2\x2\x2\x1F4\x1F6\t\x3\x2\x2\x1F5\x1F7\t\x4\x2"+
		"\x2\x1F6\x1F5\x3\x2\x2\x2\x1F6\x1F7\x3\x2\x2\x2\x1F7\x1F9\x3\x2\x2\x2"+
		"\x1F8\x1FA\x5\x87\x44\x2\x1F9\x1F8\x3\x2\x2\x2\x1FA\x1FB\x3\x2\x2\x2\x1FB"+
		"\x1F9\x3\x2\x2\x2\x1FB\x1FC\x3\x2\x2\x2\x1FC\x1FE\x3\x2\x2\x2\x1FD\x1F4"+
		"\x3\x2\x2\x2\x1FD\x1FE\x3\x2\x2\x2\x1FE\x8C\x3\x2\x2\x2\x1FF\x200\av\x2"+
		"\x2\x200\x201\at\x2\x2\x201\x202\aw\x2\x2\x202\x209\ag\x2\x2\x203\x204"+
		"\ah\x2\x2\x204\x205\a\x63\x2\x2\x205\x206\an\x2\x2\x206\x207\au\x2\x2"+
		"\x207\x209\ag\x2\x2\x208\x1FF\x3\x2\x2\x2\x208\x203\x3\x2\x2\x2\x209\x8E"+
		"\x3\x2\x2\x2\x20A\x20E\t\x5\x2\x2\x20B\x20D\t\x6\x2\x2\x20C\x20B\x3\x2"+
		"\x2\x2\x20D\x210\x3\x2\x2\x2\x20E\x20C\x3\x2\x2\x2\x20E\x20F\x3\x2\x2"+
		"\x2\x20F\x90\x3\x2\x2\x2\x210\x20E\x3\x2\x2\x2\x211\x215\a$\x2\x2\x212"+
		"\x214\x5\x95K\x2\x213\x212\x3\x2\x2\x2\x214\x217\x3\x2\x2\x2\x215\x213"+
		"\x3\x2\x2\x2\x215\x216\x3\x2\x2\x2\x216\x218\x3\x2\x2\x2\x217\x215\x3"+
		"\x2\x2\x2\x218\x219\a$\x2\x2\x219\x92\x3\x2\x2\x2\x21A\x21B\a)\x2\x2\x21B"+
		"\x21C\x5\x95K\x2\x21C\x21D\a)\x2\x2\x21D\x94\x3\x2\x2\x2\x21E\x221\n\a"+
		"\x2\x2\x21F\x221\x5\x97L\x2\x220\x21E\x3\x2\x2\x2\x220\x21F\x3\x2\x2\x2"+
		"\x221\x96\x3\x2\x2\x2\x222\x223\a^\x2\x2\x223\x224\t\b\x2\x2\x224\x98"+
		"\x3\x2\x2\x2\x225\x226\a\x31\x2\x2\x226\x227\a\x31\x2\x2\x227\x22B\x3"+
		"\x2\x2\x2\x228\x22A\n\t\x2\x2\x229\x228\x3\x2\x2\x2\x22A\x22D\x3\x2\x2"+
		"\x2\x22B\x229\x3\x2\x2\x2\x22B\x22C\x3\x2\x2\x2\x22C\x23A\x3\x2\x2\x2"+
		"\x22D\x22B\x3\x2\x2\x2\x22E\x22F\a\x31\x2\x2\x22F\x230\a,\x2\x2\x230\x234"+
		"\x3\x2\x2\x2\x231\x233\v\x2\x2\x2\x232\x231\x3\x2\x2\x2\x233\x236\x3\x2"+
		"\x2\x2\x234\x235\x3\x2\x2\x2\x234\x232\x3\x2\x2\x2\x235\x237\x3\x2\x2"+
		"\x2\x236\x234\x3\x2\x2\x2\x237\x238\a,\x2\x2\x238\x23A\a\x31\x2\x2\x239"+
		"\x225\x3\x2\x2\x2\x239\x22E\x3\x2\x2\x2\x23A\x23B\x3\x2\x2\x2\x23B\x23C"+
		"\bM\x2\x2\x23C\x9A\x3\x2\x2\x2\x23D\x23E\t\n\x2\x2\x23E\x23F\x3\x2\x2"+
		"\x2\x23F\x240\bN\x2\x2\x240\x9C\x3\x2\x2\x2\x14\x2\xA2\x192\x19E\x1E4"+
		"\x1E9\x1ED\x1F2\x1F6\x1FB\x1FD\x208\x20E\x215\x220\x22B\x234\x239\x3\b"+
		"\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace SLangGrammar
