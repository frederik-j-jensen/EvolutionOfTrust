# EVOLUTION OF TRUST
By Frederik J. Jensen, 2023

Based on "The Evolution of Trust" (https://ncase.me/trust/)


# Purpose

When I came across "The Evolution of Trust" years ago I was quite taken with both the model and how it is presented. 
You know, "I wish I had done that" kind of thing and I returned to the website every once in a while over the years.

Recently, I reflected upon the resilience of groups that are clearly biased to trust only members of its own group. 
Put on a MAGA hat and you are instantly a member of a group with a number of perks. While there may also be costs involved, 
clearly, it must be a good strategy under some circumstances, as it is still around after 50 000 years of evolution and as 
it is common in multiple cultures and periods.

So when my calendar opened up some free time and I wanted to explore Visual Studio 2022, I took it upon myself 
as a fun challenge to recreate the model from "The Evolution of Trust" and then to extend it to explore the question: 

//Can I reproduce that having a biased group is a feasible strategy in some scenarios?//


# Reproduction of the result from NCase

First, I implemented the original model from NCase, with unit tests to verify that my implementation can reproduce the results.

The solution uses a model-view-controller pattern to separate the logic controls the simulation into three components.
The class Game consists of a model (Universe), a view (GameView), and a controller (GameController). 
GameView creates textual descriptions of a game. GameController defines the actions that modify the state of the game.

PopulationBuilders and Parameters control the initial population and the rules of the game. Actors implements the actors, 
each with their own strategy for playing selecting moves.


# Exploration of scenarios with biased actors

Next, I implemented every Actor having a colour attribute and a new Biased Actor that always trust someone with the same 
colour and always cheat someone with a different colour. Also, five new populations (PopulationBuilders) explore how 
a Biased Actor competes in different scenarios.

The program runs a number of scenarios and writes the output into a text file.


# Further work

EvolutionModels develops the idea that a population can grow and decline. In a world of plenty, the population grows, 
in a world where resources are scarce, the population decline until possibly an equilibrium is found. 
This idea is not explored fully.