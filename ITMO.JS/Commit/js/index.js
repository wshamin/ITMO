window.onload = function() {
    // Проверяем настройку темы
    let currentTheme = localStorage.getItem('theme');
    
    if (currentTheme === 'dark') {
        document.body.classList.add('dark-mode');
        document.getElementById("theme-switcher").textContent = 'Светлый';
    }

    // Назначаем обработчик события на кнопку переключения темы
    document.getElementById("theme-switcher").addEventListener("click", switchTheme);
}

// Функция для переключения темы
function switchTheme() {
    let body = document.body;
    let themeSwitcher = document.getElementById("theme-switcher");
    
    if (body.classList.contains('dark-mode')) {
        body.classList.remove('dark-mode');
        themeSwitcher.textContent = 'Темный';
        localStorage.setItem('theme', 'light');
    } else {
        body.classList.add('dark-mode');
        themeSwitcher.textContent = 'Светлый';
        localStorage.setItem('theme', 'dark');
    }
}
