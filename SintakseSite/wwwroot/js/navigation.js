(() => {
    const header = document.querySelector('.ss-header');
    const toggle = header?.querySelector('.ss-menu-toggle');
    const nav = header?.querySelector('.ss-nav');
    if (!toggle || !nav) return;
    toggle.hidden = false;
    header.classList.add('is-enhanced');
    const close = () => {
        header.classList.remove('is-menu-open');
        toggle.setAttribute('aria-expanded', 'false');
    };
    toggle.addEventListener('click', () => {
        const open = header.classList.toggle('is-menu-open');
        toggle.setAttribute('aria-expanded', String(open));
    });
    header.addEventListener('keydown', event => {
        if (event.key === 'Escape' && header.classList.contains('is-menu-open')) {
            close();
            toggle.focus();
        }
    });
    document.addEventListener('click', event => { if (!header.contains(event.target)) close(); });
    nav.addEventListener('click', event => { if (event.target.closest('a')) close(); });
    window.matchMedia('(min-width: 801px)').addEventListener('change', close);
    window.addEventListener('pageshow', close);
    // Preserve bookmarks pointing to sections of the former single page.
    if (['/', '/home', '/home/index'].includes(location.pathname.toLowerCase())) {
        const routes = {'#autori':'/autori', '#pasakumi':'/pasakumi', '#arhivs':'/pasakumi#arhivs', '#par-mums':'/par-mums', '#kontakti':'/kontakti', '#gallery':'/Gallery'};
        if (routes[location.hash]) location.replace(routes[location.hash]);
    }
})();
