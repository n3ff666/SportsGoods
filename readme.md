# ООО_Спортивные_товары

Приложение для спортивных товаров предоставляет пользователям возможность удобно и быстро взаимодействовать с ассортиментом продукции. В приложении реализованы функции регистрации и авторизации, просмотр каталога товаров, добавление их в корзину, оформление заказов, а также возможность редактирования информации о товарах (для администраторов). Интуитивно понятный интерфейс и продуманный функционал обеспечивают удобство использования для всех категорий пользователей.

## Начало работы

Эти инструкции предоставят вам копию проекта и помогут запустить на вашем локальном компьютере для разработки и тестирования.

### Необходимые условия

1. **Операционная система**: Windows 10 (версии 20H2 и выше) или Windows 11.  
2. **Среда разработки**: Visual Studio 2022 (скачать с [официального сайта](https://visualstudio.microsoft.com/)).  
  - Убедитесь, что при установке выбраны рабочие нагрузки для разработки на .NET (или другой требуемой платформы).  
3. **Дополнительное ПО**:  
  - Установленный .NET SDK (версии 6.0 и выше).  
  - Git (для клонирования репозитория).  
4. **Жесткий диск**: не менее 5 ГБ свободного места.  
5. **Оперативная память**: минимум 8 ГБ для стабильной работы Visual Studio.

### Установка

1. **Установка необходимых инструментов**  
  a. Скачайте и установите Visual Studio 2022 с [официального сайта](https://visualstudio.microsoft.com/).  
  b. При установке выберите рабочую нагрузку **Разработка на .NET** или другую соответствующую платформу, если проект использует другую технологию.  
  c. Установите Git с [официального сайта](https://git-scm.com/) для работы с репозиторием.  

2. **Клонирование репозитория проекта**  
  a. Откройте терминал (Git Bash, Command Prompt или PowerShell).  
  b. Выполните команду:  
     ```bash
     git clone <ссылка_на_репозиторий>
     ```  
  c. Перейдите в папку с проектом:  
     ```bash
     cd <название_папки>
     ```  

3. **Установка SDK и зависимости**  
  a. Убедитесь, что .NET SDK версии 6.0 или выше установлен. Скачайте его с [официального сайта .NET](https://dotnet.microsoft.com/).  
  b. Если проект использует пакетный менеджер (например, NuGet), выполните восстановление зависимостей:  
     ```bash
     dotnet restore
     ```  

4. **Открытие проекта в Visual Studio**  
  a. Запустите Visual Studio 2022.  
  b. Нажмите **Открыть проект или решение** и выберите файл решения проекта (.sln) в папке с репозиторием.  

5. **Настройка конфигурации**  
  a. В Visual Studio выберите конфигурацию сборки: **Debug** (для разработки) или **Release** (для выпуска).  
  b. Настройте параметры запуска, если проект требует локального сервера или базы данных.  

6. **Запуск проекта**  
  a. Нажмите кнопку **Запустить** (или клавишу F5) в Visual Studio.  
  b. Дождитесь, пока приложение скомпилируется и запустится. Оно должно открыться в браузере или соответствующей среде выполнения.  

7. **Проверка работы**  
  a. Откройте приложение и убедитесь, что основные функции (регистрация, просмотр товаров, оформление заказов) работают корректно.  
  b. При необходимости настройте базу данных или параметры конфигурации в файлах `appsettings.json` (или аналогичных).  

Ваш проект готов к использованию!

## Авторы

* **Алексей Пресняков** - *Initial work* - [n3ff666](https://github.com/n3ff666)
