# GameEnginesBonus
Bonus marks to make up for midterm in Game Engine Design

////////

Student Number: 100785826

1 + 0 + 0 + 7 + 8 + 5 + 8 + 2 + 6 = 37

37 is PRIME

////////

Designated game is Donkey Kong

Designated singleton pattern use: Powerup manager

Designated command pattern use: Powerup that undoes one of DK's actions

////////

INSTRUCTIONS:

Left and right arrow keys: MOVE

Space bar: JUMP

////////

SINGLETON IMPLEMENTATION: POWERUP MANAGER

Singleton was implemented by attaching the PowerUpManager.cs script to a "GameManager" empty GameObject. 

This script contains a publicly accessible boolean, "isPoweredUp", which can be accessed by any objects in the scene which it is relevant to by calling "GetPoweredUp()". The barrels in the scene are affected by whether or not the player has collected a powerup, either restarting the scene if the player makes contact or destroying themselves when the player makes contact. To determine this, they check the boolean value.

The boolean value can be toggled by calling "PowerUpToggle()", which the powerup collectible uses to change the player's state when collected.

This feature's implementation benefits the game by keeping the code relevant to the player being powered up in one place that can be accessed by anything that needs it. This allows for all actions related to this powerup to be added in various locations without requiring a messily strung together net of GameObjects which need to be attached to each other to exchange information related to the powerup state. If enemies were to be added which also needed to know about the powerup state, they can call the same "PowerUpManager.instance.GetPoweredUp()" to check, without needing to be attached to a powerup script/have a powerup script attached. It is a massive benefit.

////////

COMMAND PATTERN IMPLEMENTATION: NOT ATTEMPTED

Out of time

////////

Executable .zip file can be found under Releases
