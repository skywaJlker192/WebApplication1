## ЛЕГКИЙ И СРЕДНИЙ УРОВНИ В ЭТИХ ФАЙЛАХ
<img width="748" height="23" alt="image" src="https://github.com/user-attachments/assets/52f93a0f-4b33-49e0-bf67-cf0b7cc3f420" />

Обычный режим: Index() → _ViewStart видит, что ViewData["Mode"] не установлен → использует _AppLayout → показывает шапку, боковую панель, подвал

Режим печати: Print() → устанавливает ViewData["Mode"] = "Print" → _ViewStart переключается на _PrintLayout → _PrintLayout вкладывается в _Layout, но не рендерит шапку/подвал → только контент

Кнопка печати: секция Actions в Index.cshtml рендерится в _Layout через @RenderSection("Actions") → кнопка ведёт на /Dashboard/Print
