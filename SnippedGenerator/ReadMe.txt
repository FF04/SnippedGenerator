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