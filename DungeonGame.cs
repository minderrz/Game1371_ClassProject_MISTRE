using UnityEngine;

public class DungeonGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // (PART B) TODO B1: declare your stats here, at the very top of Start,
        //          once you have had the Variables lecture. You will need:
        //            playerName (string), health (int), attack (int),
        //            agility (int), gold (int), hasKey (bool),
        //            goblinHealth (int), goblinAttack (int).
        // Player stats
        int critRoll = 6;
        int critMultiplier = 2;
        string playerName = "Conan";
        int health = 100;
        int attack = 20;
        int playerDefense = 5;
        //int agility = 10;
        int gold = 0;
        bool hasKey = true;
        int heroArmorClass = 10;

        // Goblin Stats
        int goblinHealth = 10;
        int goblinAttack = 5;
        int goblinDefense = 4;
        int goblinArmorClass = 4;

        // Ogre Stats
        int ogreHealth = 15;
        int ogreAttack = 6;
        int ogreDefense = 7;
        int ogreArmorClass = 5;


        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins."); // replace Hero with the name of your player.

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        int goldInEntranceHall = 50;
        Debug.Log("You find " +goldInEntranceHall + " gold.");
        gold += goldInEntranceHall;
        Debug.Log("You now have " + gold + " gold.");
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        int rustySwordAttack = 5;
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("Goblin awakens");
        attack += rustySwordAttack;
        Debug.Log("The goblin hits you for " + goblinAttack + " damage");
        health -= (goblinAttack + playerDefense + heroArmorClass);
    
        if (health <= 0)
        {
            Debug.Log(playerName + " has collapsed. GAME OVER.");
        }
        else if (health <= 20)
        {
            Debug.Log(playerName + " has dangerously low health.");
        }
        else
        {
            Debug.Log(playerName + " has been hurt, but is steady.");
        }
        Debug.Log("You have taken " + goblinAttack + " amount of damage.");
        health -= (health - goblinAttack);

        Debug.Log("You now have " + health + " health");
        if (health <= 0)
        {
            Debug.Log(playerName + " has collapsed. GAME OVER.");
        }
        else if (health <= 20)
        {
            Debug.Log(playerName + " has dangerously low health.");
        }
        else
        {
            Debug.Log(playerName + " has been hurt, but is steady.");
        }
        
        Debug.Log("You attack for " + attack + " damage");
        goblinHealth -= (attack - goblinDefense - goblinArmorClass);
        Debug.Log("The goblin was defeated.");

        Debug.Log("You move into the next room.");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        Debug.Log("The Flooded Passage"); //no semicolon
        int trapDamage= 2;
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        Debug.Log("A leech has attached itself to your ankle. Take " + trapDamage + " damage");
        health -= trapDamage;
        if (health <= 0)
        {
            Debug.Log(playerName + " has collapsed. GAME OVER.");
        }
        else if (health <= 20)
        {
            Debug.Log(playerName + " has dangerously low health.");
        }
        else
        {
            Debug.Log(playerName + " has been hurt, but is steady.");
        }
        Debug.Log("You move into the next room.");

        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        Debug.Log("The Moon Room");
        Debug.Log("The ceiling is made of glass and the moonlight illuminates the room.");
        Debug.Log("You find an exit behind the armoire and leading through a narrow hallway.");

        Debug.Log("Merchant Room");
        int potionCost = 7;
        Debug.Log("The room has many wares and supplies to choose from");
        Debug.Log("A man is standing in a corner has many potions for sell. He is selling potions at " + potionCost + " gold each");
        Debug.Log("You can buy " + gold / potionCost + " and you would have " + gold % potionCost + " gold left over");
        Debug.Log("You exit the same way you enter");
        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.
        Debug.Log("The Exit Hall");
        Debug.Log("You see a light shimmering through a large crack in the wall.");
        Debug.Log("You squeeze through the crack and exit the dungeon");

        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        int goldInRoom = 5000;
        Debug.Log("The Treasure Room");
        Debug.Log("It seems this room has been raided. You find " + goldInRoom + " gold and one key.");
        gold += goldInRoom;
         
        Debug.Log("You move into the next room.");
        Debug.Log("You see a large locked vault door");
        Debug.Log("The hero may pass if they have they key and are still alive.");
        
        if ((health > 0) && (hasKey))
        {
            Debug.Log("Hero passes through the vault door.");
        } 
        else
        {
            if (!hasKey)
            {
                Debug.Log("You do not have the key and cannot pass");
            }
            if ( health <=0)
            {
                Debug.Log("You died.");
            }
        }

        Debug.Log("As the hero explores, every third room has a red glow.");
        int roomNumber = 1; //I wasn't sure if I should pick 1 or 0.
        
        if (roomNumber % 3 == 0)
        {
            Debug.Log("This room glows red.");
        }
        else
        {
            Debug.Log("This room does not glow.");
        }

        Debug.Log("");
        Debug.Log("The Grainery");
        Debug.Log("You search the grainery through the open hatch door.");
        Debug.Log("A lone loaf of stale bread is on a table.");
        int staleBread = 10;
        health += staleBread;
        Debug.Log(playerName + " now has" + health + " health.");
        Debug.Log(playerName + " passes through the vault room and finds a forked path, there are two ways to continue on.");
        Debug.Log("The path to the left is rough and rocky, but clear of brush and wildlife.");
        Debug.Log("The path to the right is smooth, but has dense forest up ahead occupied with unknown creatures.");
        Debug.Log("The paths seem to rejoin further on.");
        Debug.Log(playerName + " takes the path to the left");
        Debug.Log("");
        Debug.Log("The Goblin's Cave");
        Debug.Log("Suddenly, a goblin appears.");
        // B1: A goblin blocks the way - fight it round by round until one of you

        //     runs out of health. Give the hero and the goblin each an armor

        //     class. On every swing, roll a die (Random.Range works well) and

        //     compare it to the target's armor class: the blow only lands if the

        //     roll meets or beats that armor class. On top of that, any of the

        //     hero's landed hits can be a critical hit that deals extra damage.

        //     Report each roll and its result, and after any round in which the

        //     hero takes damage, run your A5 condition check.
        int attackRound = 1;
        int helmetArmor = 2;
        Debug.Log (playerName + " finds a helmet, " + helmetArmor + " has been added to " + playerName + " defense.");
        playerDefense += helmetArmor;
        

        while (goblinArmorClass > 0 && heroArmorClass > 0)
        {
            int diceRoll = Random.Range(1,6);
            if (diceRoll >= goblinArmorClass)
            {
                int damage = attack -goblinDefense;
                if (diceRoll == critRoll)
                {
                damage = attack * critMultiplier - goblinDefense;
                Debug.Log("Round " + attackRound + ": you roll " + diceRoll + "- critical for " + damage + ".");
                }
                else 
                {
                    Debug.Log("Round " + attackRound + ":you roll " + diceRoll + " and hit for " + damage + ".");
                }
                goblinHealth -= damage;
            }
            else
            {
                Debug.Log("Round " + attackRound + ": you roll " + diceRoll + " and miss.");
            }

            if (goblinHealth > 0)
            {
                int goblinRoll = Random.Range(1,6);
                if (goblinRoll >= heroArmorClass)
                {
                    health -= goblinAttack - playerDefense;
                    Debug.Log(" the goblin rolls " + goblinRoll + " and hits. Health: " + health);
                    if (health <=0)
                    {
                        Debug.Log(playerName + " has collapsed. GAME OVER");
                    }
                    else if (health <= 20)
                    {
                        Debug.Log(playerName + " has dangerously low health.");
                    }
                    else
                    {
                        Debug.Log(playerName + " has been hurt, but is steady.");
                    }
                }
                
                {
                    Debug.Log(" the goblin rolls " + goblinRoll + " and misses.");
                }   
            }
            attackRound++;
        }
        if (goblinHealth <= 0)
        {
            Debug.Log("The goblin has been defeated.");
        }
        else
        {
            Debug.Log("The goblin stands, and you have fallen...");
        }
        
        Debug.Log("");
        Debug.Log(playerName + " turns around after defeating the goblin to find a large ugly Ogre.");
         
        while (ogreArmorClass > 0 && heroArmorClass > 0)
        {
            int diceRoll = Random.Range(1,6);
            if (diceRoll >= ogreArmorClass)
            {
                int damage = attack -ogreDefense;
                if (diceRoll == critRoll)
                {
                damage = attack * critMultiplier - ogreDefense;
                Debug.Log("Round " + attackRound + ": you roll " + diceRoll + "- critical for " + damage + ".");
                }
                else 
                {
                    Debug.Log("Round " + attackRound + ":you roll " + diceRoll + " and hit for " + damage + ".");
                }
                ogreHealth -= damage;
            }
            else
            {
                Debug.Log("Round " + attackRound + ": you roll " + diceRoll + " and miss.");
            }

            if (ogreHealth > 0)
            {
                int ogreRoll = Random.Range(1,6);
                if (ogreRoll >= heroArmorClass)
                {
                    health -= ogreAttack - playerDefense;
                    Debug.Log(" the goblin rolls " + ogreRoll + " and hits. Health: " + health);
                    if (health <=0)
                    {
                        Debug.Log(playerName + " has collapsed. GAME OVER");
                    }
                    else if (health <= 20)
                    {
                        Debug.Log(playerName + " has dangerously low health.");
                    }
                    else
                    {
                        Debug.Log(playerName + " has been hurt, but is steady.");
                    }
                }
                
                {
                    Debug.Log(" the goblin rolls " + ogreRoll + " and misses.");
                }   
            }
            attackRound++;
        }
        if (ogreHealth <= 0)
        {
            Debug.Log("The ogre has been defeated.");
        }
        else
        {
            Debug.Log("The ogre stands, and you have fallen...");
        }
        //My unity kept freezing after implementing this loop for the ogre
  
        

        // TODO B3: Go back through your rooms above and add an event/item to each
        //          one that changes a stat/variable, printing the new value right
        //          after the event. Like with the gold in the treasure room, keep
        //          each event inside the room where it happens. Possible events:
        //            pick up a sword to increase attack      
        //            step on a trap        
        //            grab the rusty key    
        //            (your own event)

        // TODO B4: In the appropriate room, add a goblin. The goblin attacks the
        //          player and the player attacks the goblin. Use the variables
        //          you've created in PART A to simulate this with code. After the
        //          simulation is done, Print both healths, then print whether or 
        //          not the goblin is defeated. 

        // TODO B5: Add a new room somewhere before the exit that has a merchant. 
        //          The merchant sells potions for 5 gold each. Print how many
        //          potions you can afford and how much gold you will have left over. 

        // TODO B6: Add a defense stat (declare it up top with the others). Use it
        //          in your combat so the goblin's hit damage is reduced by your
        //          defense and your hit damage is reduced by the goblin's defense
        //          Then, add an item that raises defense in a room. 
               // ================= PART A - CONDITIONALS (do after L7) =================

        // A1: After the goblin fight, report whether the goblin was defeated or

        //     the hero was the one who fell.

        // A2: At a vault door, the hero may pass only if they are carrying the

        //     key and are still alive. If they cannot pass, report which of the

        //     two requirements they are missing.

        // A3: The passage forks in two. Send the hero down one of the routes and

        //     describe each one - the two routes may even rejoin at the same

        //     place further on.

        // A4: As the hero explores, every third room they enter has a red glow.

        //     Given the number of the room the hero is standing in, report

        //     whether this room has the red glow.

        // A5: Whenever the hero takes damage, report their condition: collapsed

        //     if no health remains, badly wounded if their health has dropped

        //     dangerously low, or otherwise hurt but steady. This is a snippet

        //     you will reuse a lot - go back through everything you have already

        //     written (INCLUDING your previous assignment) and drop it in right

        //     after every place the hero loses health (the spike trap, and

        //     anywhere else). You will add it again in Part B after each hit the

        //     hero takes in a fight.

 

        // ================= PART B - LOOPS (do after L8) =================

        // Place the following combat encounters in different rooms of your choice.

        // B1: A goblin blocks the way - fight it round by round until one of you

        //     runs out of health. Give the hero and the goblin each an armor

        //     class. On every swing, roll a die (Random.Range works well) and

        //     compare it to the target's armor class: the blow only lands if the

        //     roll meets or beats that armor class. On top of that, any of the

        //     hero's landed hits can be a critical hit that deals extra damage.

        //     Report each roll and its result, and after any round in which the

        //     hero takes damage, run your A5 condition check.

        // B2: Beyond the goblin waits an ogre - slow, but brutal. Fight it the

        //     same way (armor classes, dice rolls to hit, and the hero's chance

        //     to crit), except the ogre is so sluggish it only swings every

        //     other round. Fight until one of them falls, and keep running your

        //     A5 check whenever the hero takes damage.

        // B3: Then a giant spider drops from the ceiling. Fight it just like the

        //     ogre - dice-and-armor-class swings, the hero's crits, and it too

        //     only strikes every other round - but its bite is venomous: any

        //     time it lands a hit, the hero is poisoned and loses 2 health at

        //     the start of each of the next three rounds, on top of the bite

        //     itself. Fight until one of them falls, running your A5 check after

        //     any damage (including the poison ticks).

        // B4: With the fights behind them, the hero rests at a campfire,

        //     recovering a little health each turn until fully healed or the

        //     fire dies after a set number of turns. Report their health as it

        //     climbs, and never let it rise above the maximum.

        int restTurns = 0;
        while (health < maxHealth && turnsRested < campfireTurns);
        {
            health =+ healPerTurn;
            if(health = maxHealth);
        }
        restTurns++;
        Debug.Log(playerName + " has rested and health is now " + health + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
