# Task Manager
NCC project with login system


Day 2
@program.cs
1)add sevices 
-likw database as SqlITE
-add identityuser sign in required
-add Entitty frameworkstores for ApllicationDbcontext 
2)http request configure
-map controller route 

@app setting.json

Choose db as mysql
 add git ignore as new file +fix .git problem nested .git deleted .Day 2 completed.


day 3
1)what i build
-create taskitem.cs with property like id,user,user id ,createdat,completedat,Isduedate,duedate,Iscompleted,task priority
-applicationuse-add two property with collection
-applicationdbcontext-modelcreating with task collection where i put relation of one user many task,descirption requiredment,iscompleted,index

2)What confused me: i though i need table first but we create it here in model then migrate it to db .
-not knowing package i need,syntax
-why base.OnModelCreating matters

3)What I now understand: migration → apply sequence, 
 
4)Question for later: how we get collection of task inverse or something
how blueprint map to migration