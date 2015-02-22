# Daniel Selmes  - Development Log Book

### 3-02-15 Beginning development
Today we started development. I set up a github repo, which should make it easy for everybody to have the latest version of the software we're making. I also began some of the design for the main application window. This window is supposed to be where the user manages thier files and for the domain and can save and load domains that they are currently working on. I have the basic layout done, but there's lots to improve on. I also made a small start on a set of icons for the application to use, to give visual hints as to what each UI element does. 

I learned that Visual Studio is pretty picky with keeping track of project files, and that if you don't move and delete stuff from inside Visual Studio, it ususally can't find the files it's looking for. I think there may also be some wierd side effects with github and Visual studio, but I'll have to look into that some more. 

### 6-02-15 Continued work on the interface
Today I did a ton of work on the interfaces, I pretty much finished up the main window, as well as getting a little bit of the navigation code done, and then started on the room editor. There are a lot of settings that can be very widely configured, such as exits, enters, and object description. I'll need to think up some kind of UI element or dialog that can let the user easily edit properties of an item. I'll also need to get the program to eventually compile these into proper C files.

I learned quite a bit about the customizable options of rooms and the different ways that you can present information to the mudlib. Mappings are a moderately complex data type that is very good for asscociating bits of information together with objects and properties of a room, and I'll need to find a way to effectively present them to the end user. It would also be good to have some kind of integrated functionality for functionals, which allow the user to write small custom functions that describe a room. 

### 8-02-15 Finished reading functionality for the mapping editor
Today and yesterday I spent quite a bit of time writing up a module with some LPC parsing functions, to make our lives easier when we start to re-write the rest of the modules. It's acutally really hard to parse code well. I also used these functions to pretty much finish up the reading functionality of the MS mapping editor. Hopefully the other mapping editors aren't so painful, there was a lot of work, and trial and error. I think it's mostly working now though. However, there's still some failsafe functionality that needs to be attached to some of the functions, in case they get passed values which don't work. I'm also going to have to test the modules later, to make sure they work.

I learned that alot of Visual Studio's guessing and suggestions are based on typing and documentation, and that when one of those is missing, it gets really hard to program the functionality you want. Thankfully, by explicitly typing (OOP typing, not keyboard typing) all my variables and providing the XML documentation for any functions I write, it makes it mostly easy to keep on top of things. Also, comments and temporary debug statements help as well.

### 22-02-15 Finished mapping editor and implemented it as item list editor
Over the past couple weeks I've been working on getting the mapping editor to a working state. No matter how the interface turns out I'll need to have functions that process LPC code, so it's good to get it out of the way now while I still have lots of free time. There's alot of coding involved, but I'm knocking out a large portion of the project right now by doing it, so it's ok. Also, the interface is looking quite bland right now, I'd rather there be more icons and colors by the time we show the prototypes to the client.  

While I've been working on this section of the program, I've found that my problem solving process seems to have a distinct set of steps:
- Come up with an algorithm to solve the problem
- Implement it and do a few quick tests
- If it works, stick with it for now, if not...
- Add MsgBox statements whenever they're needed, and breakpoints, where I think a value may be something it shoudln't
- Use these debug methods to fix the current algorithm, or if all hope is lost, think of a new one (Based on what I learned from the debugging)
I'm not too sure whether this is a good way to solve problems, but it's been working for me so far. Although, this tends to lead to not very well documented code, and I felt the effects of this when a function that I *thought* worked didn't work in reality, and the code was a little confusing for me. I may go on a commenting/documenting spree soon and fix up all that. The other problem is that my testing is too nice, and I need to try all the corner cases in order to make sure the modules work properly, or at least provide a descriptive error message. So I'll probably go add some safety checks and do a few tests with my code as well when I go on the commenting spree. 
