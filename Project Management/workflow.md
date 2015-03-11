#Workflow / Data flow

This file outlines the intended workflow for users of our program, so we can consider all aspects of the program and make notes about possible problems and solutions. It'll be especially helpful when we come to the implementation and testing stage, as we'll need to figure out what the user might want to do whilst they're using the program, and how we can accomodate that. 

##Ouline of modules and data-flow

###File browser
Let's the user browse all of thier game files, which have been imported into the program as a list of directories to search for game files. Sorts the file lists into each of the different types of file. Allows users to easily open game files which can then be edited by each of the different editing programs. 

Data wise, it uses a stored list of directories to search to generate a list of files, and allows the user to easily open each of the editors. Passes a file to the editor when it opens it. (May also pass some file location lists to the programs, but that's behind the scenes optimization stuff.)

###Room editor
Made for editing rooms. They can either make a new file or open an existing one. They make edits, save those edits, and more edits, close the editor when they're done. Should work mostly independedntly as a room file editor. 

In terms of data flow, optionally recevies a file path to open (from the program that spawned it), and tries to open that file for editing, otherwise, opens a template exmaple for editing and saving as a new file. Should be able to save over another file, or save as a new file. 

###Item editor
Pretty much identical to the room editor, except that it edits items. Copy paste the thing above here.

###Weapon editor
Chuck in something here Daniel. :)

###Armour editor editor
Chuck in something here Daniel. :)

###NPC editor
Chuck in something here Daniel. :)