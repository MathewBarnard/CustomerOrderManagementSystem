using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderManagementSystem.Menus {
    class NavigationManager {

        Stack<Menu> navTrail;

        public NavigationManager() {
            navTrail = new Stack<Menu>();
        }

        public void NavigateTo(Menu nextMenu) {
            navTrail.Push(nextMenu);
        }

        public void NavigateBack() {
            navTrail.Pop();
        }

        public void ShowCurrentMenu() {
            navTrail.Peek().Show();
        }
    }
}
