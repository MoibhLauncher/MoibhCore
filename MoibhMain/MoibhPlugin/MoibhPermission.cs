using System;
using System.Collections.Generic;
using System.Text;

namespace MoibhPlugin
{
    public class MoibhPermission
    {
        public static int onUserLogin;
        public static int onUserLogout;
        public static int onMoibhStart;
        public static int onMoibhClose;
        
        //Minecraft相关权限
        public static MinecraftPermission minecraft = new MinecraftPermission();

        //好友系统相关权限
        public static FriendPermission friend = new FriendPermission();

        //懒人社区相关权限
        public static LazyBBS lazybbs = new LazyBBS();
    }

    public class MinecraftPermission
    {
        public int minecraft;
        public int operate;
        public int onCmdReq;
    }
    public class FriendPermission
    {
        public int frierdList;
        public int friendRequest;
        public int gameRequest;
        public int message;
    }
    public class LazyBBS
    {
        public int message;
    }
}
