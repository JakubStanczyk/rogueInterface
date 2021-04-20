using System;
using RogueInterface.Generation;
/// <summary>
/// Summary description for Class1
/// </summary>
public class Memento

{
	public readonly int numberOfRooms;
	public readonly int doorAttachedToRooms;
	public readonly int gameLevel;
	public readonly int heightOfRoom;
	public readonly int widthOfRoom;

	public Memento(int numberOfRooms, int doorAttachedToRooms, int gameLevel, int heightOfRoom, int widthOfRoom)
	{
		this.numberOfRooms = numberOfRooms;
		this.doorAttachedToRooms = doorAttachedToRooms;
		this.gameLevel = gameLevel;
		this.heightOfRoom = heightOfRoom;
		this.widthOfRoom = widthOfRoom;
	}

}
