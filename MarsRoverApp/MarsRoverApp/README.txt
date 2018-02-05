****Mars Rover APP****

The Mars Rover App enables a user to send commands to the rover based on the surface area size,
last known postion of the rover and a list of commands to indicate where the rover should move to.

**Instructions**

Run the MarsRoverApp.exe and follow prompts.


**Development Process**

Based of the specification that was given from the challenge the following requirements were established : 

(Reason for this is to ensure that I understand the overview of the requirement as well as I've learnt the sometimes form the basis of the project documentation.)

1. A program is required to enable a user to send commands to a rover on Mars.
2. The layout of Mars surface was set out as a two-dimensional grid of square areas. Each zone is represented by a single cartesian coordinate.
3. The rover understand the following commands :
	a. Cardinal points which determine how big the current zone is.
	b. Direction in which it faces. East(E), West(W), North(N) and South(S)
	c. List of movement commands. M- move one space forward, R - rotate 90 degrees to the right and L - rotate 90 degrees to the left.

After establishing the requirement research was done to refresh the concepts of a cartesian plane.

** App Design **

Based off this a design was decided on for the Rover class in regards to properties and methods.

1. The area size of the supplied zone. 
    a. Field Name : ZoneSizeX   
	b. Type : int
	a. Field Name : ZoneSizeY   
	b. Type : int
2. The current horizontal and vertical axis points would have to be set where the rover is. 
	a. Field Name : PositionX   
	b. Type : int
	a. Field Name : PositionY   
	b. Type : int
3.The commands the rover needs the follow
	a. Field Name : Commands   
	b. Type : string
4. Enum value of Rover Compass Direction
	a. Field Name : RoverPosition
	b. Type : CompassValue (Enum)
5. Method to calculate first to see if the input results into an available position, if so send the new position back to the program. If not return message indicating it is not possible. 
	a. Method Name : CalculateRoverPosition.
	b. Return Type : string.
6. Method to check position is valid
7. Method to handle a left/right turns or forward move.


** App Workflow **

After class layout was decided on the skeleton of the app workflow was set out.

1. First user would be prompted to enter in the zone size. Here validation should be set to ensure the user only enters in 2 integers.
2. The user would be prompted to provide the current x and y positions on the plane 
3. Then the direction the rover is to be facing. (Here the descision was made to split this into two prompts so each could be validated correctly)
4. A list of commands which only contain the letters M,R and L would be requested and validated against a regex to ensure it's correct.
5. There after the app will display either the new position or to indicate that provided commands was not possible.
6. An InputValidations class will be created to maintain the validation of input provided by the user.

** Testing **

Due to the layout planning testing scenario's can be set out.

The following scenario's was decided to be tested :
1. Validation tested that can be done on the input validation class for successful and unsuccessful input.
2. Initial base testing to ensure that caculation returns example results as expected.
3. Test to ensure that when a user inputs a command that is not possible within the plane a notifcation returns.




   


