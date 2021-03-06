/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar SLangGrammar;

start: (moduleImport)* module;
moduleImport: Import Id;
module: (Empty)? Module Id moduleDeclareSeq (moduleStatementsSeq)?;
moduleStatementsSeq: Start statementSeq End;
moduleDeclareSeq: (functionDecl | procedureDecl | typeDecl | moduleFieldDecl | emptyTypeDecl)*;

declare: variableDecl | constDecl;
variableDecl: (simpleDecl | arrayDecl | ptrDecl);
simpleDecl: Variable (simpleType | customType) Id (Assign exp)?;
arrayDecl: arrayDeclType Id ;
arrayDeclType: Array (LSBrace exp RSBrace)+ scalarType;
ptrDecl: ptrType Id (Assign exp)?;
constDecl: Const scalarType Id Assign exp;
moduleFieldDecl:  (importHead)? AccessModifier (variableDecl | constDecl) Semicolon;

typeName: scalarType | arrayType;
ptrType: Pointer (LBrace customType RBrace)?; // id -- ���
customType: qualident;
scalarType: simpleType | customType | ptrType;
simpleType : SimpleType; // ���������� ���� 
SimpleType: Real | Integer | Boolean | Character | String;
arrayType: Array (arrayDimention)+ scalarType;
arrayDimention : LSBrace RSBrace;

typeDecl: AccessModifier (Base)? Class Id (typeInherit)? (typeFieldDecl)* End;
typeInherit: Inherit LBrace customType RBrace;
typeFieldDecl: AccessModifier variableDecl Semicolon;
emptyTypeDecl: importHead AccessModifier Empty Class Id Semicolon;

functionDecl: (importHead)? AccessModifier (Abstract | Override)? (thisHeader)? Function LBrace routineArgList RBrace Colon typeName Id statementSeq End;
thisHeader: LBrace customType Id RBrace;
routineArgList: (routineArg (Comma routineArg)* | /* ��� ���������� */ );
routineArg: FunctionArgModifier typeName Id;
procedureDecl: (importHead)? AccessModifier (Abstract | Override)? (thisHeader)? Procedure LBrace routineArgList RBrace Id statementSeq End;
importHead: LSBrace From StringLiteral Import StringLiteral RSBrace;

statementSeq: (statement)*;
statement: simpleStatement | complexStatement;
simpleStatement: (declare | let | input | output | returnC | call) Semicolon;
complexStatement: ifC | whileC | repeatC;

let: Let designator Assign exp;
input: Input designator (Comma designator)*;
output: Output exp (Comma exp)*;
returnC: Return (exp)?;
call: Call designator;

ifC: If LBrace exp RBrace Then statementSeq (Elseif LBrace exp RBrace Then statementSeq)* (Else statementSeq)? End;
whileC: While LBrace exp RBrace Do statementSeq End;
repeatC: Repeat statementSeq While LBrace exp RBrace;

exprList: (exp (Comma exp)* | /* nothing*/);
exp: simpleExpr ((BoolEq | BoolNeq | BoolG | BoolL | BoolLeq | BoolGeq) exp)?; 
simpleExpr: term ((AddOp | SubOp | BoolOr) simpleExpr)?;
term: signedFactor ((MulOp | DivOp | BoolAnd) term)?;
signedFactor: (AddOp | SubOp)? factor;
factor:  designator | ( IntValue | RealValue | BoolValue | StringLiteral | SingleCharacter | Nil ) | (BoolNot factor) | newC | (LBrace exp RBrace);
newC: New LBrace customType RBrace;
designator: Id (designatorStatement)*;
designatorStatement: (Point Id | LSBrace exp RSBrace | LBrace exprList RBrace);
qualident: (Id Point)? Id;

// ���������� � ������ ������
AddOp: '+';
SubOp: '-';
MulOp: '*';
DivOp: '/';
ModOp: '%';

BoolOr: '||';
BoolAnd: '&&';

BoolEq: '==';
BoolNeq: '!=';
BoolG: '>';
BoolL: '<';
BoolGeq: '>=';
BoolLeq: '<=';
BoolNot: '!';

// ������� ������� � �����
Colon: ':';
Semicolon: ';';
Comma: ',';
Point: '.';

Variable: 'variable';
Const: 'const';
Let: 'let';
Return: 'return';
Input: 'input';
Output: 'output';
Call: 'call';

If: 'if';
Then: 'then';
Else: 'else';
While: 'while';
Repeat: 'repeat';
Elseif: 'elseif';
Do: 'do';

Module: 'module';
Import: 'import';

Start: 'start';
End: 'end';

Function: 'function';
Procedure: 'procedure';

LBrace: '(';
RBrace: ')';

LSBrace: '[';
RSBrace: ']';

Assign: ':='; // ������������

// ����
fragment Integer: 'integer'; // | 'int'
fragment Real: 'real';
fragment Character: 'character'; // | 'char'
fragment Boolean: 'boolean'; // | 'bool'
fragment String: 'string';

// ������ ��� ����������
New: 'new'; // ��������� ������
Nil: 'nil'; // �������� null
Pointer: 'pointer'; // ���������

Array: 'array'; // ��������� ���

FunctionArgModifier : ArgValModifier | ArgRefModifier ; // �������� ���������� � ������� �� �������� � ������
fragment ArgValModifier: 'val';
fragment ArgRefModifier: 'ref';

AccessModifier: PublicModifier | PrivateModifier; // ������������ �������
fragment PublicModifier: 'public';
fragment PrivateModifier: 'private';

Class: 'class';
Empty: 'empty';

Inherit: 'inherit'; // ����� ��������� ���-����
Base: 'base'; // �� ������ ����� ������������� 

Abstract: 'abstract';
Override: 'override'; // ����� ����������������

From: 'from';

fragment Digit: [0-9]; // �����

IntValue: Digit+; // ����� �����
RealValue: Digit*Point?Digit+([eE][-+]?Digit+)?; // ������������ ��������
BoolValue: 'true' | 'false'; // ������ ��������

Id: [_a-zA-Z][_a-zA-Z0-9]*; // �������������

StringLiteral:	'"' StringCharacter* '"'; // ��������� �������
SingleCharacter: '\'' StringCharacter '\'';
fragment StringCharacter: ~["] | EscapeSequence; // ������
fragment EscapeSequence : '\\' [btnfr"'\\]; // escape-������� ���� \n \t ... ���� ������ 1 �������

Comment: ('//' ~[\r\n]* | '/*' .*? '*/') -> skip;
Ws: [ \t\r\n] -> skip;