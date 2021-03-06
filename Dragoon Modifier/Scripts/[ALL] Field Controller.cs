using Dragoon_Modifier;
using System;

public class FieldController {
    public static void Run(Emulator emulator) {
		Globals.BATTLE_VALUE = emulator.ReadShort(Constants.GetAddress("BATTLE_VALUE"));
		Globals.DISC = emulator.ReadByte(Constants.GetAddress("DISC"));
		Globals.CHAPTER = (byte) (emulator.ReadByte(Constants.GetAddress("CHAPTER")) + 1);
		Globals.ENCOUNTER_ID = emulator.ReadShort(Constants.GetAddress("ENCOUNTER_ID"));
		Globals.MAP = emulator.ReadShort(Constants.GetAddress("MAP"));
		Globals.PARTY_SLOT[0] = emulator.ReadByte(Constants.GetAddress("PARTY_SLOT"));
		Globals.PARTY_SLOT[1] = emulator.ReadByte(Constants.GetAddress("PARTY_SLOT") + 4);
		Globals.PARTY_SLOT[2] = emulator.ReadByte(Constants.GetAddress("PARTY_SLOT") + 8);
		Globals.DRAGOON_SPIRITS = emulator.ReadByte(Constants.GetAddress("DRAGOON_SPIRITS"));
		Globals.IN_BATTLE = Globals.BATTLE_VALUE == 41215 ? true : Globals.BATTLE_VALUE == 9999 ? true : false;
		
		/*if (!Globals.STATS_CHANGED && Globals.BATTLE_VALUE != 9999) {
			Constants.WriteDebug("Battle Value: " + Globals.BATTLE_VALUE + " / In Battle: " + 
			 Globals.IN_BATTLE + " / Disc: " + Globals.DISC + " / " + "Chapter: " + (Globals.CHAPTER) +
			 " / Encounter: " + Globals.ENCOUNTER_ID + " / Map: " + Globals.MAP);
			 Constants.WriteDebug("Current Time: " + DateTime.Now.ToString("h:mm:ss tt"));
		}*/
	}
	
	public static void Open(Emulator emulator) {}
	public static void Close(Emulator emulator) {}
	public static void Click(Emulator emulator) {}
}