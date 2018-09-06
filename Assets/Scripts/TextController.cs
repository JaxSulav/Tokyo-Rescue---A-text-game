using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TextController : MonoBehaviour {

    public Text text;

    private enum States {Initial, Door, FloorT, FloorO, FloorK, FloorI, FloorO2, BT, DT, BO, DO, BK, DK, BI, DI,
                         BO2, DO2, Dilemma, Jump, Fight, Balcony, StairsUp, Pathway, StairsDown, Final }
    private States CurrentState;

	// Use this for initialization
	void Start () {
        text.text = "\n\n\n" +
            "                                                 Press P to play the game.......";
        CurrentState = States.Initial;
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(CurrentState); // for log
        if (CurrentState == States.Final) { Application.Quit(); }
        if (CurrentState==States.Initial && Input.GetKeyDown(KeyCode.P)){ CurrentState = States.Door; }
        if(CurrentState == States.Initial) { Start(); }
        if (CurrentState == States.Door) { Door(); }
        if (CurrentState == States.FloorT) { FloorT(); }
        if (CurrentState == States.BT) { BT(); }
        if (CurrentState == States.DT) { DT(); }
        if (CurrentState == States.FloorO) { FloorO(); }
        if (CurrentState == States.BO) { BO(); }
        if (CurrentState == States.DO) { DO(); }
        if (CurrentState == States.FloorK) { FloorK(); }
        if (CurrentState == States.BK) { BK(); }
        if (CurrentState == States.DK) { DK(); }
        if (CurrentState == States.FloorI) { FloorI(); }
        if (CurrentState == States.BI) { BI(); }
        if (CurrentState == States.DI) { DI(); }
        if (CurrentState == States.FloorO2) { FloorO2(); }
        if (CurrentState == States.BO2) { BO2(); }
        if (CurrentState == States.DO2) { DO2(); }
        if (CurrentState == States.Dilemma) { Dilemma(); }
        if (CurrentState == States.Jump) { Jump(); }
        if (CurrentState == States.Fight) { Fight(); }
        if (CurrentState == States.Balcony) { Balcony(); }
        if (CurrentState == States.StairsUp) { StairsUp(); }
        if (CurrentState == States.StairsDown) { StairsDown(); }
        if (CurrentState == States.Pathway) { Pathway(); }
        

    }

    void Door()
    {
        text.text = "You are at the main door of a building where a child is captured as a hostage. "+
                    "The child is somewhere inside the building. Also the tessorist is somewhere inside "+
                    "but they are not in the same room. The building has 5 Floors named as Floor T, O, K, I & O2 "+
                    "not sequentially ordered. "+
                    "You have to search through floors and rooms to find the hostage and rescue. If you find the "+
                    "terrorist first, you will die. You can access any floor through the lift near the main door. Let's GO....\n"+
                    "Remember that you can go to any floor. Choose randomly because choosing Sequentially will make you find "+"" +
                    "terrorist first and believe me you will die."+
                    "Press \n T =====> FloorT,\n O =====> FloorO,\n K =====> FloorK,\n I ======> FloorI,\n "+
                    "2 =====> FloorO2";
        if (Input.GetKeyDown(KeyCode.T)) { CurrentState = States.FloorT; }
        if (Input.GetKeyDown(KeyCode.O)) { CurrentState = States.FloorO; }
        if (Input.GetKeyDown(KeyCode.K)) { CurrentState = States.FloorK; }
        if (Input.GetKeyDown(KeyCode.I)) { CurrentState = States.FloorI; }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { CurrentState = States.FloorO2; }

    }

    void FloorT()
    {
        text.text = "Welcome! to the Floor T. There are 2 rooms here, Bedroom and Dining."+
                    " Remember, you can also go to any other floors from here. Choose where do you want to go: \n"+
                    "Press:\n O =====> FloorO,\n K =====> FloorK,\n I ======> FloorI,\n 2 =====> FloorO2 \n\n"+
                    "Or Press:\n B =====> Bedroom OR D =====> Dining \n\n Press R to Return to the main door";

        if (Input.GetKeyDown(KeyCode.O)) { CurrentState = States.FloorO; }
        if (Input.GetKeyDown(KeyCode.K)) { CurrentState = States.FloorK; }
        if (Input.GetKeyDown(KeyCode.I)) { CurrentState = States.FloorI; }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { CurrentState = States.FloorO2; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.BT; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.DT; }
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.Door; }
    }

    void FloorO()
    {
        text.text = "Welcome! to the Floor O. There are 2 rooms here, Bedroom and Dining." +
                    " Remember, you can also go to any other floors from here. Choose where do you want to go: \n" +
                    "Press:\n T =====> FloorT,\n K =====> FloorK,\n I ======> FloorI,\n 2 =====> FloorO2 \n\n" +
                    "Or Press:\n B =====> Bedroom OR D =====> Dining \n\n Press R to Return to the main door";

        if (Input.GetKeyDown(KeyCode.T)) { CurrentState = States.FloorT; }
        if (Input.GetKeyDown(KeyCode.K)) { CurrentState = States.FloorK; }
        if (Input.GetKeyDown(KeyCode.I)) { CurrentState = States.FloorI; }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { CurrentState = States.FloorO2; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.BO; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.DO; }
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.Door; }
    }

    void FloorK()
    {
        text.text = "Welcome! to the Floor K. There are 2 rooms here, Bedroom and Dining." +
                    " Remember, you can also go to any other floors from here. Choose where do you want to go: \n" +
                    "Press:\n T =====> FloorT,\n O =====> FloorO,\n I ======> FloorI,\n 2 =====> FloorO2 \n\n" +
                    "Or Press:\n B =====> Bedroom OR D =====> Dining \n\n Press R to Return to the main door";

        if (Input.GetKeyDown(KeyCode.T)) { CurrentState = States.FloorT; }
        if (Input.GetKeyDown(KeyCode.O)) { CurrentState = States.FloorO; }
        if (Input.GetKeyDown(KeyCode.I)) { CurrentState = States.FloorI; }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { CurrentState = States.FloorO2; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.BK; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.DK; }
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.Door; }
    }

    void FloorI()
    {
        text.text = "Welcome! to the Floor I. There are 2 rooms here, Bedroom and Dining." +
                    " Remember, you can also go to any other floors from here. Choose where do you want to go: \n" +
                    "Press:\n T =====> FloorT,\n O =====> FloorO,\n K ======> FloorK,\n 2 =====> FloorO2 \n\n" +
                    "Or Press:\n B =====> Bedroom OR D =====> Dining \n\n Press R to Return to the main door";

        if (Input.GetKeyDown(KeyCode.T)) { CurrentState = States.FloorT; }
        if (Input.GetKeyDown(KeyCode.O)) { CurrentState = States.FloorO; }
        if (Input.GetKeyDown(KeyCode.K)) { CurrentState = States.FloorK; }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) { CurrentState = States.FloorO2; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.BI; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.DI; }
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.Door; }
    }

    void FloorO2()
    {
        text.text = "Welcome! to the Floor O2. There are 2 rooms here, Bedroom and Dining." +
                    " Remember, you can also go to any other floors from here. Choose where do you want to go: \n" +
                    "Press:\n T =====> FloorT,\n O =====> FloorO,\n K ======> FloorK,\n I =====> FloorI \n\n" +
                    "Or Press:\n B =====> Bedroom OR D =====> Dining \n\n Press R to Return to the main door";

        if (Input.GetKeyDown(KeyCode.T)) { CurrentState = States.FloorT; }
        if (Input.GetKeyDown(KeyCode.O)) { CurrentState = States.FloorO; }
        if (Input.GetKeyDown(KeyCode.K)) { CurrentState = States.FloorK; }
        if (Input.GetKeyDown(KeyCode.I)) { CurrentState = States.FloorI; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.BO2; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.DO2; }
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.Door; }
    }

    void BT()
    {
        text.text = "You are in the bedroom of Floor T. The sheets are messed up and there is blood scattered "+
            "on the ground. Something has happened in this room. But there is no sign of anybody in the room."+
            " \n\n Press::\n\n R to return to the "+
            "corridor again.";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorT; }
    }

    void DT()
    {
        text.text = "You reached the dining of Floor T. No sign of people here, but the plates are on the "+
            "table adn the food is served. Seems like they were ready to dine.\n\n Press::\n\n R to return to "+
            "the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorT; }
    }

    void BO()
    {
        text.text = "You are in the bedroom of Floor O. There is a bad smell comming from under the bed. You look under "+
            "and there is a dead dog laying but no people here. Such a pity. What kind of person does this? "+
            "You decide to leave this room.\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorO; }
    }

    void DO()
    {
        text.text = "OH NOOOO! There is the terrorist ready to grab some lunch right in front of you.\n\n A moment "+
            "of silence..... \n\n You try to run but he shoots you. "+"" +
            "                                     GAME OVER !!!!!! \n\n\n\n Press Enter to play again. ";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Door; }
    }

    void BK()
    {
        text.text = "You are in the bedroom of Floor K. Oh! wait it looks like there is something under the bed sheets. "+
            "You decide to look up under the bed sheets. Oh, it was just the pillow. It seems no one is here."+
            "\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorK; }
    }

    void DK()
    {
        text.text = "Everything is scattered here. Seems like there had been a fight here. The table is also broken and "+
            "water is running through the tap. No one seems to be in here. You decide to close the tap and leave."+
            "\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorK; }
    }

    void BI()
    {
        text.text = "The bedroom is totally messed up but you hear something. It's the child crying in the "+
            "corner. You've got to hurry and take the child with you because the terrorist might be here "+
            "anytime soon.\n\n\n Press Enter to take the child and leave the room.";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Dilemma; }
    }

    void DI() // A mystery room, for the later possible expansion of the storyline
    {
        text.text = "You don't understand what is wrong here. Everything is like untouched here, no sign of people ever being "+
            "here. There is dust all over the utensils. It seems this room hasn't been used for a long time. Still you feel there's "+
            "something this room is trying to give. You suddenly remember that you have to find the hostage and decide to leave and keep looking"+
            "\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorI; }
    }

    void BO2()
    {
        text.text = "You are in the bedroom of Floor BO2. OH! Wait, it seems like something is on the bed. You go closer and find "+
            "a gun, a FN-P90 which you recognise from the game you used to play. You decide to hide the gun somewhere in the room. "+
            "No sign of people here so you choose to leave."+
            "\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorO2; }
    }

    void DO2()
    {
        text.text = "No sign of anyone here. There is an extremely bad order of something burnt, you look around and "+
            "find the stove running. You turn it off and while leaving you decide to grab the knife from the shelf."+
            "\n\n Press::\n\n R to return to the corridor";
        if (Input.GetKeyDown(KeyCode.R)) { CurrentState = States.FloorO2; }
    }

    void Dilemma()
    {
        text.text = "OH NOOOO! You hear the footsteps of the terrorist approaching and have to make a decision "+
            "soon. You have 3 alternatives to choose. You can jump through the window, go to the balcony, or "+
            "fight the terrorist.\n\n Press::\n\n J to jump out of window \n B to go to the balcony \n F to "+
            "fight the terrorist";

        if (Input.GetKeyDown(KeyCode.J)) { CurrentState = States.Jump; }
        if (Input.GetKeyDown(KeyCode.F)) { CurrentState = States.Fight; }
        if (Input.GetKeyDown(KeyCode.B)) { CurrentState = States.Balcony; }
    }

    void Jump()
    {
        text.text = "Damnnn! You fell and didn't stick the landing. :( \n\n "+
            "                                     GAME OVER !!!!!! \n\n\n\n Press Enter to play again. ";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Door; }
    }

    void Fight()
    {
        text.text = "You collect some courage and fight the terrorist. You defeat the terrorist but the child "+
            "had accidentally died during the fight.\n\n"+
            "                                     MISSION FAILED!!!!! \n\\n"+
            "                                     GAME OVER !!!!!! \n\n\n\n Press Enter to play again. ";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Door; }
    }

    void Balcony()
    {
        text.text = "You have reached the balcony and look for the escape alternatives. You find that "+
            "there is a track of starirs alongside, going up and down. You also find that there is a pathway "+
            "bridge going to the another building. \n\n Press:::\n\n U to take the stairs up \n P to take the "+
            "pathway bridge \n D to go down the stairs";
        if (Input.GetKeyDown(KeyCode.U)) { CurrentState = States.StairsUp; }
        if (Input.GetKeyDown(KeyCode.D)) { CurrentState = States.StairsDown; }
        if (Input.GetKeyDown(KeyCode.P)) { CurrentState = States.Pathway; }
    }

    void StairsUp()
    {
        text.text = "You have reached the top of the building but there is no way down. "+
            "The terrorist finds you and you are dead now.\n\n"+
            "                                     GAME OVER !!!!!! \n\n\n\n Press Enter to play again. ";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Door; }
    }

    void Pathway()
    {
        text.text = "You are crossing the bridge but the terrorist sees you through the window and shoots."+
            "\n\n                                 BAAMMMMMMM!!! YOU ARE DEAD.....\n\n"+
            "                                     GAME OVER !!!!!! \n\n\n\n Press Enter to play again. ";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Door; }
    }

    void StairsDown()
    {
        text.text = "You go down the stairs and make it succesfully to the ground. Police arrives and secure "+
            "the hostage but the terrorist has escaped. Congratulations! You are a HERO and awarded the honour "+
            "by the police.... :D .....\n \nThe police are in search for the terrorist... :::O \n\n Press Enter to "+
            "restart the game..\n\n Press Q to quit the game.. \n\n\n Created "+
            "and written by:\n Sulav Shrestha\n";
        if (Input.GetKeyDown(KeyCode.Return)) { CurrentState = States.Initial; }
        if (Input.GetKeyDown(KeyCode.Q)) { CurrentState = States.Final; }
    }


}
