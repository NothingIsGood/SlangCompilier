/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

grammar SLangGrammar;

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
Readonly: 'readonly';

If: 'if';
Then: 'then';
Else: 'else';
While: 'while';
Repeat: 'repeat';
Elseif: 'elseif';
Do: 'do';

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

LABrace: '{';
RABrace: '}';

Assign: ':='; // ������������

// ����
Integer: 'integer'; // | 'int'
Real: 'real';
Character: 'character'; // | 'char'
Boolean: 'boolean'; // | 'bool'
String: 'string';
Unit: 'unit'; // most common type

// ������ ��� ����������
New: 'new'; // ��������� ������
Nil: 'nil'; // �������� null
Pointer: 'pointer'; // ���������

Array: 'array'; // ��������� ���

FunctionArgModifier : ArgValModifier | ArgRefModifier ; // �������� ���������� � ������� �� �������� � ������
ArgValModifier: 'val';
ArgRefModifier: 'ref';

AccessModifier: PublicModifier | PrivateModifier; // ������������ �������
PublicModifier: 'public';
PrivateModifier: 'private';

Class: 'class';

Inherit: 'inherit'; // ����� ��������� ���-����
Base: 'base'; // �� ������ ����� ������������� 

Abstract: 'abstract';
Override: 'override'; // ����� ����������������

File: 'file';

SimpleType: Real | Integer | Boolean | Character | String | Unit;

typeName: scalarType | arrayType;
ptrType: Pointer (LBrace customType RBrace)?; // id -- ���
customType: qualident;
scalarType: simpleType | customType | ptrType;
simpleType : SimpleType; // ���������� ���� 
arrayType: Array (arrayDimention)+ scalarType;
arrayDimention : LSBrace RSBrace;

start: (moduleImport)* module;
moduleImport: Import Id;
module: Module Id moduleDeclareSeq (moduleStatementsSeq)?;
moduleStatementsSeq: Start statementSeq End;
moduleDeclareSeq: (functionDecl | procedureDecl | typeDecl | moduleFieldDecl)*;

declare: variableDecl | constDecl;
variableDecl: simpleDecl | arrayDecl | ptrDecl;
simpleDecl: Variable simpleType Id (Assign exp)?;
arrayDecl: arrayType Id (Assign exp)?;
ptrDecl: ptrType Id (Assign exp)?;
constDecl: Const typeName Id Assign exp;
moduleFieldDecl: AccessModifier (Readonly)? variableDecl Semicolon;

typeDecl: AccessModifier (Base)? Class Id (typeInherit)? (typeFieldDecl)* End;
typeInherit: Inherit LBrace customType RBrace;
typeFieldDecl: AccessModifier variableDecl Semicolon;

functionDecl: (importHead)? AccessModifier (Abstract | Override)? (thisHeader)? Function LBrace routineArgList RBrace Colon typeName Id statementSeq End;
thisHeader: LBrace customType Id RBrace;
routineArgList: (routineArg (Comma routineArg)* | /* ��� ���������� */ );
routineArg: FunctionArgModifier Id;
procedureDecl: (importHead)? AccessModifier (Abstract | Override)? (thisHeader)? Procedure LBrace routineArgList RBrace Id statementSeq End;
importHead: LSBrace File StringLiteral Import StringLiteral RSBrace;

statementSeq: (statement)*;
statement: (simpleStatement | complexStatement);
simpleStatement: (declare | let | input | output | return | call) Semicolon;
complexStatement: if | while | repeat;

let: Let designator Assign exp;
if: If LBrace exp RBrace Then statementSeq (Elseif LBrace exp RBrace Then statementSeq)* (Else statementSeq)? End;
while: While LBrace exp RBrace Do statementSeq End;
repeat: Repeat statementSeq While LBrace exp RBrace;
input: Input designator (Comma designator)*;
output: Output designator (Comma designator)*;
return: Return (exp)?;
call: Call qualident LBrace exprList RBrace;
exprList: (exp (Comma exp)* | /* nothing*/);

exp: simpleExpr (Relation simpleExpr)?; 
Relation: BoolEq | BoolNeq | BoolG | BoolL | BoolLeq | BoolGeq;
simpleExpr: (AddOp | SubOp)? term (AddictiveOp term)*;
AddictiveOp: AddOp | SubOp | BoolOr;
term: factor (MultiplicativeOp factor)*;
MultiplicativeOp: MulOp | DivOp | BoolAnd;
factor: designator | ( IntValue | RealValue | BoolValue | StringLiteral | SingleCharacter ) | (BoolNot factor) | new;
new: New LBrace customType RBrace;
designator: qualident (Point Id | LSBrace exprList LSBrace | LBrace qualident RBrace | LBrace exprList RBrace )*;
qualident: (Id Point)? Id;

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