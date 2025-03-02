document.addEventListener('DOMContentLoaded', () => {
    const themeToggle = document.querySelector('.theme-toggle');
    const root = document.documentElement;
    const icon = themeToggle.querySelector('i');

    // Check for saved theme preference
    const savedTheme = localStorage.getItem('theme') || 'light';
    root.setAttribute('data-theme', savedTheme);
    updateIcon();

    themeToggle.addEventListener('click', () => {
        const currentTheme = root.getAttribute('data-theme');
        const newTheme = currentTheme === 'light' ? 'dark' : 'light';
        
        root.setAttribute('data-theme', newTheme);
        localStorage.setItem('theme', newTheme);
        updateIcon();
    });

    function updateIcon() {
        const currentTheme = root.getAttribute('data-theme');
        icon.className = currentTheme === 'light' ? 'fas fa-sun' : 'fas fa-moon';
        themeToggle.setAttribute('data-theme', currentTheme);
    }
});