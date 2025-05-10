using DesignPattern.MediatorPattern.lib;

namespace DesignPattern.MediatorPattern;

public class Program
{
    public static void Main()
    {
        var chatRoom = new ChatRoom();

        var user1 = new User(chatRoom, "XiaoMing");
        var user2 = new User(chatRoom, "XiaoGang");
        var user3 = new User(chatRoom, "XiaoWang");
        
        chatRoom.AddColleague(user1);
        chatRoom.AddColleague(user2);
        chatRoom.AddColleague(user3);
        
        user1.Send("Hello Everyone!");
        user2.Send("Hi XiaoMing!");
        user3.Send("Hey there!");
    }
}