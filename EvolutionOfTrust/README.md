# EVOLUTION OF TRUST
By Frederik J. Jensen, 2022

Based on "The Evolution of Trust" (https://ncase.me/trust/)


# BACKGROUND

When I came accross "The Evolution of Trust" years ago I was quite taken with both the model and how it is presented. 
You know, "I wish I had done that" kind of thing and I returned to the website every once in a while over the years.

Recently, I reflected upon the resilience of groups that are clearly biased to trust only members of its own group. 
Put on a MAGA hat and you are instantly a member of a group with a number of perks. While there may also be costs involved, 
clearly, it must be a good strategy under some circumstances, as it is still around after 50 000 years of evolution and as 
it is common in multiple cultures and periods.

So when my calendar opened up some free time and I wanted to explore Visual Studio 2022, I took it upon myself 
as a fun challenge to recreate the model from "The Evolution of Trust" and then to extend it to explore the question: 

//Can I reproduce that having a biased group is a feasible strategy in some scenarios?//

What is implemented right now is a model that has been extended with every Actor having a colour attribute and there is a new Biased Actor 
that always trust someone with the same colour and always cheat someone with a different colour. Also, there are variations 
on how to create the initial distribution of actors in the universe (PopulationBuilders) and variations on how to decide which 
actors to eliminate and which to duplicate (EvolutionModels).

The user interface is pure text based but is implemented with a Model-View-Controller pattern so a more rich user interface 
can be added later without messing up the model.

