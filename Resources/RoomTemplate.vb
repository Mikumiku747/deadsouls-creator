Module RoomTemplate

    ''' <summary>
    ''' The template string the room editor uses to generate it's output files.
    ''' </summary>
    Public template As String = "
#include <lib.h>

inherit LIB_ROOM;

static void create() {
    room::create();
    SetProperty(""light"", 2);
    SetClimate(""indoors"");
    SetGravity(3.2);
    SetTown
    SetShort(""an empty room"");
    SetDayLong(""An empty room, with a concrete floor, walls and ceiling. There is an opening in the roof, with metal bars across it, from which sunlight fills the room."");
    SetNightLong(""An empty room, with a concrete floor, walls and ceiling. There is an opening in the roof, with metal bars across it, from which moonlight fills the room."");
}
"

End Module
