// tooltip
const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

// darkmode toggle
document.getElementById("darkmode-toggle").addEventListener("click", function () {
    document.documentElement.setAttribute(
        "data-theme",
        document.documentElement.getAttribute("data-theme") === "dark" ? "light" : "dark"
    )
    document.cookie = "theme=" + document.documentElement.getAttribute("data-theme") + "; path=/; max-age=31536000";
});

// set theme from cookie
const theme = document.cookie.replace(/(?:(?:^|.*;\s*)theme\s*=\s*([^;]*).*$)|^.*$/, "$1");
if (theme) {
    document.documentElement.setAttribute("data-theme", theme);
} else {
    document.cookie = "theme=dark; path=/; max-age=31536000";
    document.documentElement.setAttribute("data-theme", "dark");
}

