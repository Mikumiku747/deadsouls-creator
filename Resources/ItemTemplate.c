#include <lib.h>
#include <vendor_types.h>
inherit LIB_ITEM;

void create() {
	::create();
	SetKeyName("itemname");
	SetId(({ "item" }));
	SetAdjectives(({ "generic","bland","boring" }));
	SetShort("an item");
	SetLong("A really generic item. It's so generic, you can't make out any features of it. Kinda wierd actually...");
	SetMass(10);
	SetValue(10);
	SetDamagePoints(100);
	SetDestroyOnSell(1);
	SetVendorType(VT_CONTRABAND)
}

void init() {
	::init();
}
