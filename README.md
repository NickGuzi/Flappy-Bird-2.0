# Flappy Bird 2.0
Flappy Bird 2.0: nostalgia and rage reincarnated. 

I was inspired to embark on this project thanks to a video on the YouTube Channel [Game Maker's Tool Kit](https://www.youtube.com/@GMTK) in which Mark recreates Flappy Bird from scratch on Unity. This is also where I acquired my sprites from for the project. Since I was given just 10 days to complete a fully functioning game on Unity, I thought Flappy Bird was a challenging yet feasible project to tackle. My main goal in recreating this game was to give users a nostalgic experience that coincided with a polished, functional, and fun final product. 

## Flappy Bird Screens 
Scene management within this project is controlled by a SceneLoader Prefab that produces a fade effect for transitioning.  

Example of scene transition: 


![Scene_Example](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/687d9e02-2e82-451e-a7b3-bc62ad20964c)


## Flappy Bird Player Movement 
Movement is kept very simple and is singularly controlled by the spacebar. A RigidBody2D was applied to the player object and movement was scripted utilizing a simple velocity equation. In order to keep Flappy Bird 2.0 as authentic to the original game as possible, in-game gravity was tweaked until the correct feel for player movement was achieved. 

Example of player movement:


![Player_Movement](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/17b7d599-2ed8-4dbb-8e41-cb2ba0792d07)


Velocity Script:


![PlayerVelocity](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/71537a38-8bc6-4eff-8e3f-292ce9dd6ea1)



## Flappy Bird Spawning
Flappy Bird tricks players into thinking the bird is flying through the air. In reality, the bird stays in a singular location with objects moving towards it, thus giving the illusion of flight. Therefore, when creating my version of Flappy Bird, it was necessary to create a spawning system which would spawn objects into the game field, move them across it, and subsequently delete them when they left it. For the pipes and point boosting diamonds this was achieved through creating object prefabs and scripting behaviors so these prefabs would repeatedly spawn at a set time just outside of the game field and then move across the screen at a set speed. The clouds you see in the background spawn through the use of a particle system prefab. This prefab can also been seen in use on the main menu screen.  

Example of pipes, diamonds, and clouds spawning:


![Spawn_Example](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/82df201d-be94-4a1c-863b-4b6e4999277b)


Script that spawns pipes (diamond script is virtually the same):


![PipeSpawn](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/b92a5eff-b329-471e-acce-8940c978b581)


Script that moves pipes across screen and then deletes them (diamond script is virtually the same): 


![PipeMove](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/34f7b7f8-c276-400d-8be1-52b36b6513db)


## Flappy Bird UI
UI is featured in the opening menu scene, gameplay score, and game over screen. Gameplay score and the game over screen are controlled by functions present within the LogicScript. The game over screen is triggered whenever a player impacts a pipe or goes too far off screen. The function addScore() features a singular parameter which tracks incrementation value. Therefore, it is able to increment score upon passing through a set of pipes (+1 to score) as well as when a player collects a diamond (+5 to score). 

LogicScript:


![LogicScript](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/eb6b85fc-5959-46cc-931e-e468e7496771)


BirdScript making use of LogicScript functions:


![BirdScript](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/187f736f-84da-482d-b482-06046ea7f3de)


addScore() function in use:


![PipeTrigger](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/5d3b56d1-fd87-4e7a-83f8-c5814134554c)
![DiamondTrigger](https://github.com/NickGuzi/Flappy-Bird-2.0/assets/140576874/4ca9fe90-b1f9-4587-8aab-3bbd0c2524bd)
