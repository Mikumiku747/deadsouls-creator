#include <lib.h>
#include <damage_types.h>
#include <vendor_types.h>

inherit LIB_ITEM;

static void create() {
    item::create();
    SetKeyName("weapon");
    SetId( ({ "weaponId"}));
    SetAdjectives( ({ "blank","Blanky"}));
    SetShort("a weapon");
    SetLong("Its a weapon of blank");
    SetMass(0);
    SetBaseCost("silver",5);
    SetVendorType(VT_WEAPON);
    SetClass(5);
    SetDamageType(KNIFE);
    SetWeaponType("knife");
}

void init(){
    ::init();
}
