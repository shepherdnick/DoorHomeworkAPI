# DoorHomeworkAPI
An API for homework submissions

## API

- Get list of buildings
- Get list of doors (no status)
- Get status of door (id: number)
- Open door (id: number)
- Close door (id: number)
- Lock door (id: number)
- Unlock door (id: number)

## TASK

- Create an application which lists the doors in the system, and show their status. 
   - (Means they'll have to create their own data structure to hold the buildings, doors and status).
- Make a filter so that the application can display only the doors for a particular building. 
   - (Shows how they can use a front end framework to give context to flat data).
- If a door is left open for more than 10 seconds, display a warning message to the user describing the door that is open. 
   - (Looks for polling of only doors that are open, and keeps a record of when that door was last checked).
 - Suggest ways the API could be improved
