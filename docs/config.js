/** боковая панель */
const sideBar = {
    loadSidebar: true, // рендерить из файла
    subMaxLevel: 2, // максимальный уровень вложенности оглавления
    auto2top: true, // при изменении маршрута прокручивается в верхнюю часть экрана.
    alias: {
        "/.*/_sidebar.md": "/_sidebar.md", // одно боковое меню на всех
    },
};

const search = {
    noData: "Никаких результатов!",
    paths: "auto",
    placeholder: "Поиск",
};

window.$docsify = {
    name: "Документация",
    repo: "https://github.com/gamedev-indie-team",
    ...sideBar,
    search,
};
