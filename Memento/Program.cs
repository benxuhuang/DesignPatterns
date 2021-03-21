using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole ben = new GameRole();
            ben.SetInitState();
            ben.StateDisplay();

            RoleStateCareTaker stateAdmin = new RoleStateCareTaker();
            stateAdmin.memento = ben.SaveState();

            ben.Fight();
            ben.StateDisplay();

            ben.RecoveryState(stateAdmin.memento);
            ben.StateDisplay();
        }
    }
}
