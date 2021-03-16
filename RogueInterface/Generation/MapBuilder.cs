using System;
class MapBuilder
{
    // Initiallize parameters for the object that will generate the maps
    int numberOfRooms;
    string sizeOfRooms;
    int doorAttachedToRooms ;
    int gameLevel;
    int heightOfRoom;
    int widthOfRoom;
    int sizeOfMap;

    // Constructor that creates a object for the generate of the map
    public MapBuilder(int numberOfRooms, string sizeOfRooms, int doorAttachedToRooms, int gameLevel, int heightOfRoom, int widthOfRoom, int sizeOfMap)
    {
        this.numberOfRooms = numberOfRooms;
        this.sizeOfRooms = sizeOfRooms;
        this.doorAttachedToRooms = doorAttachedToRooms;
        this.gameLevel = gameLevel;
        this.heightOfRoom = heightOfRoom;
        this.widthOfRoom = widthOfRoom;
        this.sizeOfMap = sizeOfMap;
    }

    public MapBuilder NumberOfRooms(int numberOfRooms){
        this.numberOfRooms = numberOfRooms;
        return this;
    }

    public MapBuilder SizeOfRooms(string sizeOfRooms){
        this.sizeOfRooms = sizeOfRooms;
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

    public MapBuilder SizeOfMap(int sizeOfMap)
    {
        this.sizeOfMap = sizeOfMap;
        return this;
    }

    public MapBuilder buildRooms(){
        return new MapBuilder(numberOfRooms, sizeOfRooms, doorAttachedToRooms, gameLevel, heightOfRoom, widthOfRoom, sizeOfMap);
    }

    public int getRoomNumber(){
        return numberOfRooms;
    }
    public String getRoomSize(){
        return sizeOfRooms;
    }

    public int getDoorNumber(){
        return doorAttachedToRooms;
    }

    public int getLevelRange(){
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

    public int getSizeOfMap()
    {
        return sizeOfMap;
    }
}