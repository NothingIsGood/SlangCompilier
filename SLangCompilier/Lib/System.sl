﻿module System
	public base class Object
	end

	[file "CppLib/System_cpp.hpp" import "System_cpp::pause_"]
	public procedure() Pause
	end

	[file "CppLib/System_cpp.hpp" import "System_cpp::toreal_"]
	public function(val integer arg): real ToReal
	end

	[file "CppLib/System_cpp.hpp" import "System_cpp::toint_"]
	public function(val real arg): integer ToInteger
	end

	[file "CppLib/System_cpp.hpp" import "System_cpp::ord_"]
	public function(val character arg): integer Ord
	end

	[file "CppLib/System_cpp.hpp" import "System_cpp::chr_"]
	public function(val integer arg): character Chr
	end