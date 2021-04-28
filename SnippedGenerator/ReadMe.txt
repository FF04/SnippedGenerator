FF - 25-04-2021
=================
Snippet generator

Infos dazu: https://docs.microsoft.com/en-us/visualstudio/ide/code-snippets-schema-reference?view=vs-2019

Idee von http://tools.unitycoder.com/VisualStudioSnippetsGenerator/
Wieso baue ich dann soetwas?
	Weil snippets noch weitere Funktionen haben können welche auf der Website nicht vorhanden sind, diese werde ich hier benutzen
	(zB.: vorgegebenen type)



	Input:	Shortcut
			Shortcut Description	
			Code
			Extras
	
	Output: a .snipped file
	


The Snipped Template is in Snippet_template.txt
to replace are all *number* (*1*, *2*, ...)



Der name von $ is "Delimiter"

Literal *3*
				<Literal>
					<ID>typeX</ID>
					<ToolTip>XXX</ToolTip>
					<Default>XXX</Default>
				</Literal>



				28.4.2021 FERTIG mit dem prinzip
			
			

							
			<SnippetTypes>
				<SnippetType>Expansion</SnippetType>
				<SnippetType>SurroundsWith</SnippetType>
			</SnippetTypes>

			Diese beiden elemente sollten nur einmal im Code vorkommen, falls sie häufiger vorkommen zählt nur das letzte
				  $selected$ $end$












				  WHAT ARE KINDS DOING???

				  Kind - Optional attribute that specifies the kind of code that the snippet contains. The value can be one of the following:

TABLE 4
		Value					Description
		method body				Specifies that the code snippet is a method body, and therefore, must be inserted inside a method declaration.
		method decl				Specifies that the code snippet is a method, and therefore, must be inserted inside a class or module.
		type decl				Specifies that the code snippet is a type, and therefore, must be inserted inside a class, module, or namespace.
		file					Specifies that the snippet is a full code file. These code snippets can be inserted alone into a code file, or inside a namespace.
		any						Specifies that the snippet can be inserted anywhere. This tag is used for code snippets that are context-independent, such as comments.



		das ist eine .NET Core solution -> zb keine MenuStrips