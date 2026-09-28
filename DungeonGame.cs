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
        string playerName = "Conan";
        int health = 100;
        int attack = 20;
        int defense = 5;
        int agility = 10;
        int gold = 0;
        bool hasKey = false;

        // Goblin Stats
        int goblinHealth = 10;
        int goblinAttack = 5;
        int goblinDefense = 2;

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
        health -= (goblinAttack - defense);
        Debug.Log("You have taken " + goblinAttack + " amount of damage.");
        Debug.Log("You now have " + health + " health");
        
        Debug.Log("You attack for " + attack + " damage");
        goblinHealth -= (attack - goblinDefense);

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
        Debug.Log("The Final Room");
        Debug.Log("You see a light shimmerings through a large crack in the wall.");
        Debug.Log("You squeeze through the crack and exit the dungeon");

        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
         int goldInRoom = 5000;
         Debug.Log("The Treasure Room");
         Debug.Log("It seems this room has been raided. You find " + goldInRoom + " gold.");
         gold += goldInRoom;
         Debug.Log("You move into the next room.");

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
