grammar floe;

program
	: (statement END_STATEMENT)* EOF
	;

statement
	: connection_statement 
	| block_statement
	| assign_statement
	;

connection_statement
	: source L_BRACKET NAME? R_BRACKET
	;

source
	:NAME
	| node
	;

value
	: NAME
	| INT_LITERAL
	;

node_name
	: RESERVED
	| NAME
	;

node
	: node_name L_PAREN arg_list R_PAREN	
	;

arg_list
	: NAME COMMA arg_list
	| NAME
	;


block_statement
	: NAME BLOCKS block_condition
	;

block_compare
	:EQ | GT | GTE | LT | LTE
	;
block_condition
	: value block_compare value
	;

assign_statement
	: NAME ASSIGN INT_LITERAL;

fragment LETTER: [a-zA-Z];
fragment ALPHANUMERIC: [a-zA-Z0-9];

L_BRACKET: '[';
R_BRACKET: ']';

L_PAREN: '(';
R_PAREN: ')';

ASSIGN: '=';

EQ: '==';
GT: '>';
GTE: '>=';
LT: '<';
LTE: '<=';

fragment PLUS: 'add';
fragment MINUS: 'subtract';
fragment MULTIPLY: 'multiply';
fragment DIVIDE: 'divide';
fragment MODULO: 'mod';
fragment PRINT: 'print';

RESERVED: PLUS | MINUS | MULTIPLY | DIVIDE | MODULO | PRINT;
BLOCKS: '!';

COMMA: ',';
END_STATEMENT: ';';

INT_LITERAL: [0-9];
NAME: LETTER ALPHANUMERIC*;

NEWLINE:'\r'? '\n' -> skip; 
WS : [ \t]+ -> skip; 

