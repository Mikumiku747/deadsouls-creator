#MSMappingEditor Dialog behaviour

##General Workflow
The dialog is passed a mapping as a string to start, and once the user is done, they can return a new mapping as a string with the corrected values.

As a special case, if the user deletes all the items, the dialog should be set to a special value so the code calling it can set it to an unset default value.

##Action behavoirs

###Dialog is created
- Dialog is given a mapping as a string
- Mapping gets pasred into keys and values, keys get converted to csv/dequoted
- Currently selected item gets set

###Chosen key gets changed
- Currently selected item is changed to match

###Key text gets changed
- Key for the currently selected item gets changed to match

###Value text is changed
- Value for the currently selected item gets changed to match

###Add button is pressed
- A new key and value is added to the bottom of the list, with some default text, and it is changed to the currently selected item. 

###Remove button is pressed
- If this is the only item in the list:
	- The dialog is closed, and we set the items to an UNSET state.
- Otherwise
	- The key and value for the current item are removed from the list, and the first item in the list is selected

###Cancel button is pressed
- Dialog is closed, no changes should be made to the current working file. 

###Save button is pressed
- Compile the mapping into it's orginal form, set the dialogValue to be the compiled mapping, close the dialog.