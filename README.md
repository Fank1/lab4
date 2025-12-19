# Lab 4 - BTs, Unity Behaviour Graph, Blackboard

![til](https://github.com/Fank1/lab4/blob/main/movie.gif?raw=true)

### Compare FSM vs Behaviour Tree for this guard. What became easier? What became harder?
The behavior tree allows for more finegrained control using conditionals. It was harder to setup then the FSM, but I can see the potential use of Behavior Tree in the future. 

### The Navigate To Target node return Running while the guard is moving. What would happen if it returned Success immediately instead? Describe the visual behaviour you’d see.
I believe the Agent/Guard would only move toward the target under 1 tick. 

### What did you put in the blackboard, and why does it belong there (vs inside one node)?
From the way I understand it, only the fields/variables directly affecting the conditions and branches of the Behavior Graph should be placed in the Blackboard. 

### If you were to scale this guard into a “real enemy,” what would you add next: more sensors, more actions, more structure (subgraphs), or better movement?
Possibly adding "turn around to search" before going back to patrolling. That would be a quite an easy win, I think. Also, researching on how to make the patrolling smoother - rounding the waypoints and smoother turning during it. 
