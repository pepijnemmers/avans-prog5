// tooltip
const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

// darkmode toggle
document.getElementById("darkmode-toggle").addEventListener("click", function () {
    document.documentElement.setAttribute(
        "data-theme", 
        document.documentElement.getAttribute("data-theme") === "dark" ? "light" : "dark"
    )}
);


