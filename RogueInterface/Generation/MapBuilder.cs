using System;
using RogueInterface.Prototype;
class MapBuilder : IPrototype<MapBuilder>
{
    // Initiallize parameters for the object that will generate the maps
    int numberOfRooms;
    int doorAttachedToRooms ;
    int gameLevel;
    int heightOfRoom;
    int widthOfRoom;
    //int sizeOfMap;

    // Constructor that creates a object for the generate of the map
    public MapBuilder(int numberOfRooms,int doorAttachedToRooms, int gameLevel, int heightOfRoom, int widthOfRoom) //int sizeOfMap)
    {
        this.numberOfRooms = numberOfRooms;
        this.doorAttachedToRooms = doorAttachedToRooms;
        this.gameLevel = gameLevel;
        this.heightOfRoom = heightOfRoom;
        this.widthOfRoom = widthOfRoom;
        //this.sizeOfMap = sizeOfMap;
        //Console.WriteLine("Level 1 will have " + numberOfRooms + " rooms, with " + doorAttachedToRooms + "doors attached to them. The rooms dimenstions are " + heightOfRoom + "units in height and " + widthOfRoom + "units in width");
    }

    public MapBuilder NumberOfRooms(int numberOfRooms){
        this.numberOfRooms = numberOfRooms;
        return this;
    }

    public MapBuilder DoorAttachedToRooms(int doorAttachedToRooms){
        this.doorAttachedToRooms = doorAttachedToRooms;
        return this;
    }

    public MapBuilder GameLevel(int gameLevel){
        this.gameLevel= gameLevel;
        return this;
    }

    public MapBuilder HeightOfRoom(int height)
    {
        this.heightOfRoom = height;
        return this;
    }

    public MapBuilder WidthOfRoom(int width)
    {
        this.widthOfRoom = width;
        return this;
    }

    /*public MapBuilder SizeOfMap(int sizeOfMap)
    {
        this.sizeOfMap = sizeOfMap;
        return this;
    }*/

    public MapBuilder buildRooms(){
        return new MapBuilder(numberOfRooms,doorAttachedToRooms, gameLevel, heightOfRoom, widthOfRoom);
    }

    public int getNumberOfRooms(){
        return numberOfRooms;
    }

    public int getDoorsAttachedToRooms(){
        return doorAttachedToRooms;
    }

    public int getGameLevel(){
        return gameLevel;
    }

    public int getHeightOfRoom()
    {
        return heightOfRoom;
    }

    public int getWidthOfRoom()
    {
        return widthOfRoom;
    }
    public MapBuilder createCopy()
    {
        var mapBuilder = (MapBuilder)MemberwiseClone();
        return mapBuilder;
    }

    /*public int getSizeOfMap()
    {
        return sizeOfMap;
    }*/
}