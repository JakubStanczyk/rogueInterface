using System;

class MapBuilder
{
    int roomNumber;
    string roomSize;
    int doorNumber ;
    string levelRange;

    public MapBuilder(int roomNumber, string roomSize, int doorNumber, string levelRange)
    {
        this.roomNumber = roomNumber;
        this.roomSize = roomSize;
        this.doorNumber = doorNumber;
        this.levelRange = levelRange;
        Console.WriteLine("You've created a set of rooms for the level range of " + levelRange + ". There is " + roomNumber + " number of rooms in this range, with " + doorNumber + " of the size" + roomSize);
    }

    public MapBuilder RoomNumber(int roomNumber){
        this.roomNumber = roomNumber;
        return this;
    }

    public MapBuilder RoomSize(string roomSize){
        this.roomSize = roomSize;
        return this;
    }

    public MapBuilder DoorNumber(int doorNumber){
        this.doorNumber = doorNumber;
        return this;
    }

    public MapBuilder LevelRange(string levelRange){
        this.levelRange = levelRange;
        return this;
    }

    public MapBuilder buildRooms(){
        return new MapBuilder(roomNumber, roomSize, doorNumber, levelRange);
    }

    public int getRoomNumber(){
        return roomNumber;
    }
    public String getRoomSize(){
        return roomSize;
    }

    public int getDoorNumber(){
        return doorNumber;
    }

    public string getLevelRange(){
        return levelRange;
    }
}