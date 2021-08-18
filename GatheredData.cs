using System.Collections.Generic;
using System.Numerics;

namespace BlueMageHelper
{
    public class GatheredData
    {
        internal List<SpellAcquisition> SpellAcquisition = new();
        
        /*
         * [13:16:22.611][Debug] [BlueMageHelper] Trying to load Blue spell names:
[13:16:22.612][Debug] [BlueMageHelper] Water Cannon:11385
[13:16:22.612][Debug] [BlueMageHelper] Flame Thrower:11402
[13:16:22.612][Debug] [BlueMageHelper] Aqua Breath:11390
[13:16:22.612][Debug] [BlueMageHelper] Flying Frenzy:11389
[13:16:22.612][Debug] [BlueMageHelper] Drill Cannons:11398
[13:16:22.612][Debug] [BlueMageHelper] High Voltage:11387
[13:16:22.612][Debug] [BlueMageHelper] Loom:11401
[13:16:22.612][Debug] [BlueMageHelper] Final Sting:11407
[13:16:22.612][Debug] [BlueMageHelper] Song of Torment:11386
[13:16:22.612][Debug] [BlueMageHelper] Glower:11404
[13:16:22.612][Debug] [BlueMageHelper] Plaincracker:11391
[13:16:22.612][Debug] [BlueMageHelper] Bristle:11393
[13:16:22.612][Debug] [BlueMageHelper] White Wind:11406
[13:16:22.612][Debug] [BlueMageHelper] Level 5 Petrify:11414
[13:16:22.612][Debug] [BlueMageHelper] Sharpened Knife:11400
[13:16:22.612][Debug] [BlueMageHelper] Ice Spikes:11418
[13:16:22.612][Debug] [BlueMageHelper] Blood Drain:11395
[13:16:22.612][Debug] [BlueMageHelper] Acorn Bomb:11392
[13:16:22.612][Debug] [BlueMageHelper] Bomb Toss:11396
[13:16:22.612][Debug] [BlueMageHelper] Off-guard:11411
[13:16:22.612][Debug] [BlueMageHelper] Self-destruct:11408
[13:16:22.612][Debug] [BlueMageHelper] Transfusion:11409
[13:16:22.612][Debug] [BlueMageHelper] Faze:11403
[13:16:22.612][Debug] [BlueMageHelper] Flying Sardine:11423
[13:16:22.612][Debug] [BlueMageHelper] Snort:11383
[13:16:22.612][Debug] [BlueMageHelper] 4-tonze Weight:11384
[13:16:22.612][Debug] [BlueMageHelper] the Look:11399
[13:16:22.612][Debug] [BlueMageHelper] Bad Breath:11388
[13:16:22.612][Debug] [BlueMageHelper] Diamondback:11424
[13:16:22.612][Debug] [BlueMageHelper] Mighty Guard:11417
[13:16:22.612][Debug] [BlueMageHelper] Sticky Tongue:11412
[13:16:22.612][Debug] [BlueMageHelper] Toad Oil:11410
[13:16:22.612][Debug] [BlueMageHelper] the Ram's Voice:11419
[13:16:22.612][Debug] [BlueMageHelper] the Dragon's Voice:11420
[13:16:22.612][Debug] [BlueMageHelper] Missile:11405
[13:16:22.612][Debug] [BlueMageHelper] 1000 Needles:11397
[13:16:22.612][Debug] [BlueMageHelper] Ink Jet:11422
[13:16:22.612][Debug] [BlueMageHelper] Fire Angon:11425
[13:16:22.612][Debug] [BlueMageHelper] Moon Flute:11415
[13:16:22.612][Debug] [BlueMageHelper] Tail Screw:11413
[13:16:22.612][Debug] [BlueMageHelper] Mind Blast:11394
[13:16:22.612][Debug] [BlueMageHelper] Doom:11416
[13:16:22.612][Debug] [BlueMageHelper] Peculiar Light:11421
[13:16:22.612][Debug] [BlueMageHelper] Feather Rain:11426
[13:16:22.612][Debug] [BlueMageHelper] Eruption:11427
[13:16:22.612][Debug] [BlueMageHelper] Mountain Buster:11428
[13:16:22.612][Debug] [BlueMageHelper] Shock Strike:11429
[13:16:22.612][Debug] [BlueMageHelper] Glass Dance:11430
[13:16:22.612][Debug] [BlueMageHelper] Veil of the Whorl:11431
[13:16:22.612][Debug] [BlueMageHelper] Alpine Draft:18295
[13:16:22.612][Debug] [BlueMageHelper] Protean Wave:18296
[13:16:22.612][Debug] [BlueMageHelper] Northerlies:18297
[13:16:22.612][Debug] [BlueMageHelper] Electrogenesis:18298
[13:16:22.612][Debug] [BlueMageHelper] Kaltstrahl:18299
[13:16:22.612][Debug] [BlueMageHelper] Abyssal Transfixion:18300
[13:16:22.612][Debug] [BlueMageHelper] Chirp:18301
[13:16:22.612][Debug] [BlueMageHelper] Eerie Soundwave:18302
[13:16:22.612][Debug] [BlueMageHelper] Pom Cure:18303
[13:16:22.612][Debug] [BlueMageHelper] Gobskin:18304
[13:16:22.612][Debug] [BlueMageHelper] Magic Hammer:18305
[13:16:22.612][Debug] [BlueMageHelper] Avail:18306
[13:16:22.612][Debug] [BlueMageHelper] Frog Legs:18307
[13:16:22.612][Debug] [BlueMageHelper] Sonic Boom:18308
[13:16:22.612][Debug] [BlueMageHelper] Whistle:18309
[13:16:22.612][Debug] [BlueMageHelper] White Knight's Tour:18310
[13:16:22.612][Debug] [BlueMageHelper] Black Knight's Tour:18311
[13:16:22.612][Debug] [BlueMageHelper] Level 5 Death:18312
[13:16:22.612][Debug] [BlueMageHelper] Launcher:18313
[13:16:22.612][Debug] [BlueMageHelper] Perpetual Ray:18314
[13:16:22.612][Debug] [BlueMageHelper] Cactguard:18315
[13:16:22.612][Debug] [BlueMageHelper] Revenge Blast:18316
[13:16:22.612][Debug] [BlueMageHelper] Angel Whisper:18317
[13:16:22.612][Debug] [BlueMageHelper] Exuviation:18318
[13:16:22.612][Debug] [BlueMageHelper] Reflux:18319
[13:16:22.612][Debug] [BlueMageHelper] Devour:18320
[13:16:22.612][Debug] [BlueMageHelper] Condensed Libra:18321
[13:16:22.612][Debug] [BlueMageHelper] Aetherial Mimicry:18322
[13:16:22.612][Debug] [BlueMageHelper] Surpanakha:18323
[13:16:22.612][Debug] [BlueMageHelper] Quasar:18324
[13:16:22.612][Debug] [BlueMageHelper] J Kick:18325
[13:16:22.612][Debug] [BlueMageHelper] Triple Trident:23264
[13:16:22.612][Debug] [BlueMageHelper] Tingle:23265
[13:16:22.612][Debug] [BlueMageHelper] Tatami-gaeshi:23266
[13:16:22.612][Debug] [BlueMageHelper] Cold Fog:23267
[13:16:22.612][Debug] [BlueMageHelper] Stotram:23269
[13:16:22.612][Debug] [BlueMageHelper] Saintly Beam:23270
[13:16:22.612][Debug] [BlueMageHelper] Feculent Flood:23271
[13:16:22.612][Debug] [BlueMageHelper] Angel's Snack:23272
[13:16:22.612][Debug] [BlueMageHelper] Chelonian Gate:23273
[13:16:22.612][Debug] [BlueMageHelper] The Rose of Destruction:23275
[13:16:22.612][Debug] [BlueMageHelper] Basic Instinct:23276
[13:16:22.612][Debug] [BlueMageHelper] Ultravibration:23277
[13:16:22.612][Debug] [BlueMageHelper] Blaze:23278
[13:16:22.612][Debug] [BlueMageHelper] Mustard Bomb:23279
[13:16:22.612][Debug] [BlueMageHelper] Dragon Force:23280
[13:16:22.612][Debug] [BlueMageHelper] Aetherial Spark:23281
[13:16:22.612][Debug] [BlueMageHelper] Hydro Pull:23282
[13:16:22.612][Debug] [BlueMageHelper] Malediction of Water:23283
[13:16:22.612][Debug] [BlueMageHelper] Choco Meteor:23284
[13:16:22.612][Debug] [BlueMageHelper] Matra Magic:23285
[13:16:22.612][Debug] [BlueMageHelper] Peripheral Synthesis:23286
[13:16:22.612][Debug] [BlueMageHelper] Both Ends:23287
[13:16:22.612][Debug] [BlueMageHelper] Phantom Flurry:23288
[13:16:22.612][Debug] [BlueMageHelper] Nightbloom:23290
[13:16:22.612][Information] Command was dispatched.

         */

        public GatheredData()
        {
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Flamethrower
                ActionID = 11402,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Gobmachine G-VI
                        MobID   = 2547,
                        TerritoryID = 362,
                        Notes = "Final boss from Brayflox's Longstop (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Einhander
                        MobID   = 3369,
                        TerritoryID = 150,
                        Notes = "First boss of The Keeper of the Lake",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Magitek Gunship
                        MobID   = 3373,
                        TerritoryID = 150,
                        Notes = "Second boss of The Keeper of the Lake",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Omega
                        MobID   = 7695,
                        TerritoryID = 800,
                        Notes = "Alphascape V3.0",
                        Coordinate = new (0,0)
                    }
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Aqua Breath
                ActionID = 11390,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Ultros
                        MobID   = 3047,
                        TerritoryID = 142,
                        Notes = "The Dragon's Neck / Masked Carnival 20",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Leviathan
                        MobID = 2550,
                        TerritoryID = 281,
                        Notes = "The Whorleater (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Leviathan
                        MobID = 2550,
                        TerritoryID = 359,
                        Notes = "The Whorleater (Extreme)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Flying Frenzy
                ActionID = 11389,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Zu
                        MobID   = 2261,
                        TerritoryID = 142,
                        Notes = "Second boss in Pharos Sirius (Kill 2 eggs to trigger the Boss to cast)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Drill Cannons
                ActionID = 11398,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Magitek Vanguard H-2
                        MobID   = 8138,
                        TerritoryID = 147,
                        Notes = "",
                        Coordinate = new (16,15)
                    },
                    new ()
                    {
                        //Magitek Vanguard
                        MobID   = 269,
                        TerritoryID = 217,
                        Notes = "Castrum Meridianum",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Magitek Vanguard H-1
                        MobID   = 2089,
                        TerritoryID = 217,
                        Notes = "Castrum Meridianum",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //High Voltage
                ActionID = 11387,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //ADS
                        MobID   = 1459,
                        TerritoryID = 241,
                        Notes = "First boss in the Binding Coil of Bahamut - Turn 1",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //ADS
                        MobID   = 1459,
                        TerritoryID = 242,
                        Notes = "First boss in the Binding Coil of Bahamut - Turn 2",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Loom
                ActionID = 11401,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Dantalion
                        MobID   = 2846,
                        TerritoryID = 373,
                        Notes = "The Tam-Tara Deepcroft (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Phantom Knight 
                        MobID   = 2848,
                        TerritoryID = 373,
                        Notes = "The Tam-Tara Deepcroft (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Baalzephon
                        MobID   = 2573,
                        TerritoryID = 363,
                        Notes = "The Lost City of Amdapor",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Final Sting
                ActionID = 11407,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Killer Wespe
                        MobID   = 8134,
                        TerritoryID = 134,
                        Notes = "",
                        Coordinate = new (15,15)
                    },
                    new ()
                    {
                        //Temple Bee
                        MobID   = 1575,
                        TerritoryID = 163,
                        Notes = "The Sunken Temple of Qarn",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Song of Torment
                ActionID = 11386,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Killer Wespe
                        MobID   = 8134,
                        TerritoryID = 134,
                        Notes = "",
                        Coordinate = new (15,15)
                    },
                    new ()
                    {
                        //Temple Bee
                        MobID   = 1575,
                        TerritoryID = 163,
                        Notes = "The Sunken Temple of Qarn",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Glower
                ActionID = 11404,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Coincounter
                        MobID   = 1533,
                        TerritoryID = 172,
                        Notes = "2. Boss in the Aurum Vale",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Plaincracker
                ActionID = 11391,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Clay Golem
                        MobID   = 30,
                        //North Shroud
                        TerritoryID = 154,
                        Notes = "",
                        Coordinate = new (19,29)
                    },
                    new ()
                    {
                        //Sandstone Golem
                        MobID   = 280,
                        //Southern Thanalan
                        TerritoryID = 146,
                        Notes = "",
                        Coordinate = new (24,13)
                    },
                    new ()
                    {
                        //Basalt Golem
                        MobID   = 365,
                        //Outer La Noscea
                        TerritoryID = 180,
                        Notes = "",
                        Coordinate = new (16,16)
                    },
                    new ()
                    {
                        //Gogmagolem
                        MobID   = 2285,
                        TerritoryID = 349,
                        Notes = "2. Boss from Copperbell Mines (Hard)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Bristle
                ActionID = 11393,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Wild Boar
                        MobID   = 16,
                        //East Shroud
                        TerritoryID = 152,
                        Notes = "",
                        Coordinate = new (18,24)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //White Wind
                ActionID = 11406,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID   = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Learn 10 Blue Magic Spells and get the Whalaqee Totem",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Level 5 Petrify
                ActionID = 11414,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Manor Sentry
                        MobID   = 428,
                        //Haukke Manor
                        TerritoryID = 166,
                        Notes = "From Manor Sentry in Haukke Manor",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Sharpened Knife
                ActionID = 11400,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Tonburry King
                        MobID   = 1547,
                        //The Wanderer's Palace
                        TerritoryID = 159,
                        Notes = "Last boss in The Wanderer's Palace",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Ice Spikes
                ActionID = 11418,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Trickster Imp
                        MobID   = 21,
                        //Central Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (27,24)
                    },
                    new ()
                    {
                        //Vandalous Imp
                        MobID   = 1198,
                        //Eastern Thanalan
                        TerritoryID = 145,
                        Notes = "",
                        Coordinate = new (15,19)
                    },
                    new ()
                    {
                        //Manor Jester
                        MobID   = 426,
                        //Haukke Manor
                        TerritoryID = 166,
                        Notes = "2. Boss in Haukke Manor",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Blood Drain
                ActionID = 11395,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Chigoe
                        MobID   = 43,
                        //Central Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (25,20)
                    },
                    new ()
                    {
                        //Cave Bat
                        MobID   = 43,
                        //Central Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (27,16)
                    },
                    new ()
                    {
                        //Sun Bat
                        MobID   = 279,
                        //Central Thanalan
                        TerritoryID = 141,
                        Notes = "",
                        Coordinate = new (28,18)
                    },
                    new ()
                    {
                        //Dusk Bat
                        MobID   = 363,
                        //Western La Noscea
                        TerritoryID = 138,
                        Notes = "",
                        Coordinate = new (27,24)
                    },
                    new ()
                    {
                        //Black Bat
                        MobID   = 38,
                        //East Shroud
                        TerritoryID = 152,
                        Notes = "",
                        Coordinate = new (17,23)
                    },
                    new ()
                    {
                        //Attic Bat
                        MobID   = 430,
                        //Haukke Manor
                        TerritoryID = 166,
                        Notes = "Trash before 1. boss in Haukke Manor",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Sand Bat
                        MobID   = 1592,
                        //Cuttler's Cry
                        TerritoryID = 170,
                        Notes = "Mob from Cuttler's Cry",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Acorn Bomb
                ActionID = 11392,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Treant Sapling
                        MobID   = 3047,
                        //North Shroud
                        TerritoryID = 142,
                        Notes = "",
                        Coordinate = new (27,28)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Bomb Toss
                ActionID = 11396,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Goblin Fisher
                        MobID   = 367,
                        //Middle La Noscea
                        TerritoryID = 134,
                        Notes = "",
                        Coordinate = new (23,21)
                    },
                    new ()
                    {
                        //Goblin Gambler
                        MobID   = 3099,
                        //Middle La Noscea
                        TerritoryID = 134,
                        Notes = "",
                        Coordinate = new (23,21)
                    },
                    new ()
                    {
                        //Goblin Glider
                        MobID   = 3601,
                        //The Dravanian Hinterlands
                        TerritoryID = 399,
                        Notes = "",
                        Coordinate = new (29,23)
                    },
                    new ()
                    {
                        //Goblin Brandisher
                        MobID   = 3598,
                        //The Dravanian Hinterlands
                        TerritoryID = 399,
                        Notes = "",
                        Coordinate = new (29,23)
                    },
                    new ()
                    {
                        //Illuminati Commander
                        MobID   = 2548,
                        //Brayflox's Longstop (Hard)
                        TerritoryID = 362,
                        Notes = "First boss in Brayflox's Longstop (Hard)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Off-guard
                ActionID = 11411,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Learn 5 Blue Magic Spells",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Self-destruct
                ActionID = 11408,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Glide Bomb
                        MobID = 8135,
                        //Western Thanalan
                        TerritoryID = 140,
                        Notes = "",
                        Coordinate = new (27,16)
                    },
                    new ()
                    {
                        //Flambeau 
                        MobID = 983,
                        //Copperbell Mines
                        TerritoryID = 161,
                        Notes = "Mob from Copperbell Mines",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Gas Bomb
                        MobID = 1193,
                        //Halatali
                        TerritoryID = 162,
                        Notes = "Mob from Halatali",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Shrapnel
                        MobID = 1799,
                        //Cutter's Cry
                        TerritoryID = 170,
                        Notes = "Mob from Cutter's Cry",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Transfusion
                ActionID = 11409,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID   = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Learn 20 Blue Magic Spells",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Faze
                ActionID = 11403,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Qiqirn Shellsweeper
                        MobID   = 266,
                        //Central Thanalan
                        TerritoryID = 141,
                        Notes = "",
                        Coordinate = new (16,19)
                    },
                    new ()
                    {
                        //Qiqirn Eggdigger
                        MobID   = 350,
                        //Lower La Noscea
                        TerritoryID = 135,
                        Notes = "",
                        Coordinate = new (18,35)
                    },
                    new ()
                    {
                        //Qiqirn Gullroaster
                        MobID   = 351,
                        //Eastern La Noscea
                        TerritoryID = 137,
                        Notes = "",
                        Coordinate = new (26,32)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Flying Sardine
                ActionID = 11423,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Apkallu
                        MobID   = 341,
                        //Eastern La Noscea
                        TerritoryID = 137,
                        Notes = "",
                        Coordinate = new (27,35)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Snort
                ActionID = 11383,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Typhon
                        MobID   = 3046,
                        TerritoryID = 142,
                        Notes = "The Dragon's Neck / Masked Carnival 20 & 27",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //4-tonze Weight
                ActionID = 11384,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Ultros
                        MobID   = 3047,
                        //The Dragon's Neck
                        TerritoryID = 142,
                        Notes = "The Dragon's Neck",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //The Look
                ActionID = 11399,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Anantaboga
                        MobID   = 1696,
                        //Amdapor Keep
                        TerritoryID = 167,
                        Notes = "Last Boss from Amdapor Keep",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Bibliolater
                        MobID   = 5223,
                        //The Great Gubal Library (Hard)
                        TerritoryID = 578,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Bad Breath
                ActionID = 11388,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Stroper
                        MobID   = 238,
                        //Central Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (13,21)
                    },
                    new ()
                    {
                        //Halitostroper
                        MobID   = 2057,
                        //Central Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (15,21)
                    },
                    new ()
                    {
                        //Stroper
                        MobID   = 238,
                        //South Shroud
                        TerritoryID = 148,
                        Notes = "",
                        Coordinate = new (20,28)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Diamondback
                ActionID = 11424,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Cuca Fera
                        MobID   = 2775,
                        //The Stone Vigil (Hard)
                        TerritoryID = 365,
                        Notes = "Second Boss from The Stone Vigil (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Horde Armored Dragon
                        MobID   = 3324,
                        //Central Shroud
                        TerritoryID = 143,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Mighty Guard
                ActionID = 11417,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID   = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Learn 10 Blue Magic Spells",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Sticky Tongue
                ActionID = 11412,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Toxic Toad
                        MobID   = 216,
                        //Central Thanalan
                        TerritoryID = 141,
                        Notes = "",
                        Coordinate = new (27,19)
                    },
                    new ()
                    {
                        //Laughing Gigantoad
                        MobID   = 217,
                        //Western Thanalan
                        TerritoryID = 140,
                        Notes = "",
                        Coordinate = new (15,7)
                    },
                    new ()
                    {
                        //Gigantoad
                        MobID   = 26,
                        //Eastern La Noscea
                        TerritoryID = 137,
                        Notes = "",
                        Coordinate = new (18,26)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Toad Oil
                ActionID = 11410,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Giggling Gigantoad
                        MobID   = 8136,
                        //Western Thanalan
                        TerritoryID = 140,
                        Notes = "",
                        Coordinate = new (15,7)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //The Ram's Voice
                ActionID = 11419,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Chimera
                        MobID   = 1590,
                        TerritoryID = 170,
                        Notes = "Last boss from Cutter's Cry",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Dhorme Chimera
                        MobID   = 2162,
                        TerritoryID = 368,
                        Notes = "A Relic Reborn: The Chimera",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Shadowcourt Hound
                        MobID   = 5521,
                        TerritoryID = 627,
                        Notes = "Mob in Dun Scaith",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //The Dragon's Voice
                ActionID = 11420,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Chimera
                        MobID   = 1590,
                        TerritoryID = 170,
                        Notes = "Last boss from Cutter's Cry",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Dhorme Chimera
                        MobID   = 2162,
                        TerritoryID = 368,
                        Notes = "A Relic Reborn: The Chimera",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Shadowcourt Hound
                        MobID   = 5521,
                        TerritoryID = 627,
                        Notes = "Mob in Dun Scaith",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Missile
                ActionID = 11405,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Enkidu
                        MobID   = 3304,
                        //Enkidu
                        TerritoryID = 396,
                        Notes = "Battle in the Big Keep",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //1000 Needles
                ActionID = 11397,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Sabotender Desertor
                        MobID   = 1594,
                        //Cutter's Cry
                        TerritoryID = 170,
                        Notes = "Mob from Cutter's Cry",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Sabotender Bailaor
                        MobID   = 8137,
                        //Southern Thanalan
                        TerritoryID = 146,
                        Notes = "",
                        Coordinate = new (16,15)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Ink Jet
                ActionID = 11422,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Kraken
                        MobID   = 2904,
                        //Sastasha (Hard)
                        TerritoryID = 387,
                        Notes = "Boss from Sastasha (Hard)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Fire Angon
                ActionID = 11425,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Frumious Koheel Ja
                        MobID   = 3091,
                        //The Wanderer's Palace (Hard)
                        TerritoryID = 188,
                        Notes = "First Boss from The Wanderer's Palace (Hard)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Moon Flute
                ActionID = 11425,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID   = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Clear 10 Stages in The Masked Carnivale",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Tail Screw
                ActionID = 11413,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Karlabos
                        MobID   = 3014,
                        //Sastasha (Hard)
                        TerritoryID = 387,
                        Notes = "Boss from Sastasha (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Reflection of Karlabos
                        MobID   = 6059,
                        //Sastasha (Hard)
                        TerritoryID = 626,
                        Notes = "Mob from Sirensong Sea",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Crag Claw
                        MobID   = 5705,
                        //The Peaks
                        TerritoryID = 620,
                        Notes = "",
                        Coordinate = new (25,11)
                    },
                    new ()
                    {
                        //Crag Claw
                        MobID   = 3764,
                        //Alexander - The Arm of the Father
                        TerritoryID = 444,
                        Notes = "Mob from Alexander - The Arm of the Father",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Mind Blast
                ActionID = 11394,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Galvanth the Dominator
                        MobID   = 73,
                        //The Tam-Tara Deepcroft
                        TerritoryID = 164,
                        Notes = "Last Boss from Sastasha (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Blaster
                        MobID   = 4699,
                        //Alexander - The Burden of the Son
                        TerritoryID = 523,
                        Notes = "From Alexander - The Burden of the Son",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Doom
                ActionID = 11416,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //null
                        MobID   = 0,
                        //null
                        TerritoryID = 0,
                        Notes = "Clear 20 Stages in The Masked Carnivale",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Peculiar Light
                ActionID = 11421,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Lentic Mudpuppy
                        MobID   = 8139,
                        //Mor Dhona
                        TerritoryID = 156,
                        Notes = "",
                        Coordinate = new (13,10)
                    },
                    new ()
                    {
                        //Surf Eft
                        MobID   = 1294,
                        //Brayflox's Longstop
                        TerritoryID = 158,
                        Notes = "Mob before Second Boss in Brayflox's Longstop",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Hellbender
                        MobID   = 1286,
                        //Brayflox's Longstop
                        TerritoryID = 158,
                        Notes = "Second Boss from Brayflox's Longstop",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Loch Nanka
                        MobID   = 5730,
                        //The Lochs
                        TerritoryID = 621,
                        Notes = "",
                        Coordinate = new (17,20)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Feather Rain
                ActionID = 11426,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Garuda
                        MobID   = 1644,
                        //The Howling Eye (Extreme)
                        TerritoryID = 297,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Eruption
                ActionID = 11427,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Ilfrit
                        MobID   = 1185,
                        //The Bowl of Embers
                        TerritoryID = 202,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Ilfrit
                        MobID   = 1185,
                        //The Bowl of Embers (Hard)
                        TerritoryID = 292,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Ilfrit
                        MobID   = 1185,
                        //The Bowl of Embers (Extreme)
                        TerritoryID = 295,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Mountain Buster
                ActionID = 11428,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Titan
                        MobID   = 1801,
                        //The Navel (Hard)
                        TerritoryID = 293,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Titan
                        MobID   = 1801,
                        //The Navel (Extreme)
                        TerritoryID = 296,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Shock Strike
                ActionID = 11429,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Ramuh
                        MobID   = 2832,
                        //The Striking Tree (Hard)
                        TerritoryID = 374,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Ramuh
                        MobID   = 2832,
                        //The Striking Tree (Extreme)
                        TerritoryID = 375,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Glass Dance
                ActionID = 11430,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Shiva
                        MobID   = 2994,
                        //Akh Afah Amphitheatre (Extreme)
                        TerritoryID = 378,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Veil of the Whorl
                ActionID = 11431,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Leviathan
                        MobID   = 2550,
                        //The Whorleater (Hard)
                        TerritoryID = 281,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Leviathan
                        MobID   = 2550,
                        //The Whorleater (Extreme)
                        TerritoryID = 359,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Alpine Draft
                ActionID = 18295,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Opinicus
                        MobID   = 3409,
                        //The Dusk Vigil
                        TerritoryID = 434,
                        Notes = "Last Boss from The Dusk Vigil",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Griffin
                        MobID   = 3526,
                        //The Sea of Clouds
                        TerritoryID = 401,
                        Notes = "",
                        Coordinate = new (36,9)
                    },
                    new ()
                    {
                        //True Griffin
                        MobID   = 5711,
                        //The Peaks
                        TerritoryID = 620,
                        Notes = "",
                        Coordinate = new (27,25)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Protean Wave
                ActionID = 18296,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Living Liquid
                        MobID   = 3765,
                        //Alexander - The Arm of the Father
                        TerritoryID = 444,
                        Notes = "Last Boss from Alexander - The Arm of the Father",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Northerlies
                ActionID = 18297,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Lone Yeti
                        MobID   = 3483,
                        //Coerthas Western Highlands
                        TerritoryID = 397,
                        Notes = "",
                        Coordinate = new (20,31)
                    },
                    new ()
                    {
                        //Slate Yeti
                        MobID   = 3490,
                        //Coerthas Western Highlands
                        TerritoryID = 397,
                        Notes = "",
                        Coordinate = new (17,27)
                    },
                    new ()
                    {
                        //Yeti
                        MobID   = 3040,
                        //Snowcloak
                        TerritoryID = 371,
                        Notes = "Second Boss in Snowcloak",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Electrogenesis
                ActionID = 18298,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Conodont
                        MobID   = 3496,
                        //The Sea of Clouds
                        TerritoryID = 401,
                        Notes = "",
                        Coordinate = new (26,33)
                    },
                    new ()
                    {
                        //Hikagiri
                        MobID   = 6228,
                        //Shisui of the Violet Tides
                        TerritoryID = 616,
                        Notes = "Mob in the beginning from Shisui of the Violet Tides",
                        Coordinate = new (17,27)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Kaltstrahl
                ActionID = 18299,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Faust
                        MobID   = 3745,
                        //Alexander - Fist of the Father
                        TerritoryID = 442,
                        Notes = "Pre-Boss in Alexander - Fist of the Father",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Jagd Doll
                        MobID   = 3759,
                        //Alexander - The Cuff of the Father
                        TerritoryID = 443,
                        Notes = "Mobs in Alexander - The Cuff of the Father",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Abyssal Transfixion
                ActionID = 18300,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Ash
                        MobID   = 2341,
                        //Haukke Manor (Hard)
                        TerritoryID = 350,
                        Notes = "Second Boss in Haukke Manor (Hard)",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Biblioklept
                        MobID   = 3931,
                        //The Great Gubal Library
                        TerritoryID = 416,
                        Notes = "Final Boss 3 Orb Spawn in The Great Gubal Library",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Level 5 Death
                ActionID = 18312,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Page 64
                        MobID   = 3915,
                        //The Great Gubal Library
                        TerritoryID = 416,
                        Notes = "Second Boss in Haukke Manor (Hard)",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Chirp
                ActionID = 18301,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Paissa
                        MobID   = 3499,
                        //Sea of Clouds
                        TerritoryID = 401,
                        Notes = "",
                        Coordinate = new (24,33)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Eerie Soundwave
                ActionID = 18302,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Enkidu
                        MobID   = 3304,
                        //Battle in the Big Keep
                        TerritoryID = 396,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Arioch
                        MobID   = 2560,
                        //The Lost City of Amdapor
                        TerritoryID = 363,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Empuse
                        MobID   = 3541,
                        //Azys Lla
                        TerritoryID = 402,
                        Notes = "",
                        Coordinate = new (30,12)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Pom Cure
                ActionID = 18303,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Furryfoot Kupli Kipp
                        MobID   = 720,
                        //Thornmarch (Hard)
                        TerritoryID = 207,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Gobskin
                ActionID = 18304,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Alexandrian Hider
                        MobID   = 5206,
                        //Alexander - The Breath of the Creator
                        TerritoryID = 581,
                        Notes = "Pre-Mob in Alexander - The Breath of the Creator",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Magic Hammer
                ActionID = 18305,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Apanda
                        MobID   = 5238,
                        //The Great Gubal Library (Hard)
                        TerritoryID = 578,
                        Notes = "Mini Boss before final boss",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Avail
                ActionID = 18306,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Queen Hawk
                        MobID   = 4656,
                        //Saint Mocianne's Arboretum
                        TerritoryID = 511,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Exuviation
                ActionID = 18318,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Wamoura
                        MobID   = 2579,
                        //The Lost City of Amdapor
                        TerritoryID = 363,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Devour
                ActionID = 18320,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Cerberus
                        MobID   = 3234,
                        //The World of Darkness
                        TerritoryID = 151,
                        Notes = "Boss from The World of Darkness",
                        Coordinate = new (0,0)
                    },
                    new ()
                    {
                        //Decaying Gourmand
                        MobID   = 2556,
                        //The Lost City of Amdapor
                        TerritoryID = 363,
                        Notes = "",
                        Coordinate = new (0,0)
                    },
                }
            });
            
            SpellAcquisition.Add(new SpellAcquisition()
            {
                //Condensed Libra
                ActionID = 18321,
                Mobs = new List<SpellAcquisitionMobs>()
                {
                    new ()
                    {
                        //Mechanoscribe
                        MobID   = 5236,
                        //The Great Gubal Library (Hard)
                        TerritoryID = 578,
                        Notes = "late trash",
                        Coordinate = new (0,0)
                    },
                }
            });
        }
    }
}