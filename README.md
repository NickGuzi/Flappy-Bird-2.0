# Flappy Bird 2.0
Flappy Bird 2.0: nostalgia and rage reincarnated. 

I was inspired to embark on this project thanks to a video on the YouTube Channel [Game Maker's Tool Kit](https://www.youtube.com/@GMTK) in which Mark recreates Flappy Bird from scratch on Unity. This is also where I acquired my sprites from for the project. Since I was given just 10 days to complete a fully functioning game on Unity, I thought Flappy Bird was a challenging yet feasible project to tackle. My main goal in recreating this game was to give users a nostalgic experience that coincided with a polished, functional, and fun final product. 

## Flappy Bird Screens 
Scene management within this project is controlled by a SceneLoader Prefab that produces a fade effect for transitioning.  

Example of scene transition: 


![Scene_Example](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/687d9e02-2e82-451e-a7b3-bc62ad20964c)



## Flappy Bird Player Movement 
Movement is kept very simple and is singularly controlled by the spacebar. A RigidBody2D was applied to the player object and movement was scripted in utilizing a simple velocity equation. In order to keep Flappy Bird 2.0 as authentic to the original game as possible, in-game gravity was tweaked until the correct feel for player movement was achieved. 

Example of player movement:

## Flappy Bird Spawning
Flappy Bird is an illusion in that players percieve the bird to be flying through the air. In reality, the bird stays in a singular location and pipes move towards it at a set speed to give the illusion of flight. This made it necessary to create a pipe spawner in which pipes would spawn into the game field, move across it, and subsequently delete themselves when they left it. This was achieved through creating a pipe object Prefab and scripting behaviors so these pipe Prefabs would repeatedly spawn at a set time just outside of the game field and then move across the screen at a set speed. This same process was utilized to spawn in the point booster diamonds you see in-game.  

Examples of spawning:

## Flappy Bird UI
UI is featured in the opening menu scene, gameplay score, and game over screen. Gameplay score and the game over screen are controlled by functions present within the LogicScript. The game over screen is triggered whenever a player impacts a pipe or goes too far off screen. The function addScore features a singular parameter which tracks incrementation value. Therefore, it is able to increment score upon passing through a set of pipes (+1 to score) as well as when a player collects a diamond (+5 to score). 

Examples of UI:

