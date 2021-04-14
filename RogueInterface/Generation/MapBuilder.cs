using System;
using RogueInterface.Generation;
using RogueInterface.Prototype;
class MapBuilder : BuildRequestDispatcher, IPrototype<MapBuilder>, IBuildRequest
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
        : base()
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
        dispatchPreBuilldRequest(this);
        MapBuilder o = new MapBuilder(numberOfRooms, doorAttachedToRooms, gameLevel, heightOfRoom, widthOfRoom);
        dispatchPostBuildRequest(this);
        return o;
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

    public void setNumberOfRooms(int val)
    {
        numberOfRooms = val;
    }

    public void setDoorsAttachedToRooms(int val)
    {
        doorAttachedToRooms = val;
    }

    public void setHeightOfRoom(int val)
    {
        heightOfRoom = val;
    }

    public void setGameLevel(int val)
    {
        gameLevel = val;
    }

    public void setWidthOfRoom(int val)
    {
        widthOfRoom = val;
    }

    protected override void dispatchPostBuildRequest(IBuildRequest context)
    {
        foreach (var inter in interceptors)
        {
            inter.onPostBuildRequest(this);
        }
    }

    protected override void dispatchPreBuilldRequest(IBuildRequest context)
    {
        foreach (var inter in interceptors)
        {
            inter.onPreBuildRequest(this);
        }
    }
}