// darkmode toggle
document.getElementById("darkmode-toggle").addEventListener("click", function () {
    document.documentElement.setAttribute(
        "data-theme", 
        document.documentElement.getAttribute("data-theme") === "dark" ? "light" : "dark"
    )}
);