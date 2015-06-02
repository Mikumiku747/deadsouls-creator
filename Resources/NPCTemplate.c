#include <lib.h>

inherit LIB_SENTIENT;

static void create() {
	sentient::create();
	SetKeyName("Blanker");
	SetId(({ "Blanker" }));
	SetAdjectives(({ "Blank" }));
	SetShort("Blank Blanker");
	SetLong("Blanky Blank BLanker Blankly Blanking");
	'SetCanBite(0);
	'SetWimpy(90);
	'SetPacifist(1);
	SetInventory((["default"]));
	SetLevel(1);
	'SetAutoStand(0);
	SetRace("human");
	SetGender("male");
	'SetConsultResponses(([]));
	'SetPosition();
	'SetPolyglot();
	'SetLanguage("common", 100);
	SetDefaultLanguage("common");
	'SetAction(5, ({}));
}
