#include <lib.h>
#include <armor_types.h>
#include <damage_types.h>
inherit LIB_ARMOR;

static void create(){
    armor::create();
    SetKeyName("The Armour of Desl Default");
    SetId(({"default","basic","defence thing","no damage","eat damage"}));
    SetAdjectives(({"defence","defence","defence","on the fence"}));
    SetShort("My my look at the defence of this armour");
    SetLong("The rare lengendary armour that is good at weighing you down is defensive");
    SetMass(0);
    SetBaseCost("silver",1000);
    SetDamagePoints(0);
    SetProtection(BLUNT,4);
    SetArmorType(A_ARMOR);
}
void init(){
    ::init();
}
