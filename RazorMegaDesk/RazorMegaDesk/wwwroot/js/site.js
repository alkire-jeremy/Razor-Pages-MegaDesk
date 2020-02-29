// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function preview() {
    var material = document.getElementById("material_input").value;

    if (material == "Oak") {
        document.getElementById("material_preview").src = "https://images.homedepot-static.com/productImages/9ce3484b-815d-46a9-9ad6-8368091db0d7/svn/bruce-hardwood-samples-ar-142696-64_400_compressed.jpg";
    }
    else if (material == "Laminate") {
        document.getElementById("material_preview").src = "https://images.homedepot-static.com/productImages/e8ff78f4-5f22-408e-bce3-2bec3f1b3cc6/svn/saratoga-hickory-wood-grain-trafficmaster-laminate-wood-flooring-34089-64_1000.jpg";
    }
    else if (material == "Pine") {
        document.getElementById("material_preview").src = "https://images.homedepot-static.com/productImages/3b0f8e7a-7fe9-4ab2-8f43-82f7b8572526/svn/hardwood-samples-p34518sm-s-64_400_compressed.jpg";
    }
    else if (material == "Rosewood") {
        document.getElementById("material_preview").src = "https://images.homedepot-static.com/productImages/a6ee41b3-8999-4b38-a27f-7bf65dbb50a7/svn/rosewood-trafficmaster-vinyl-plank-flooring-62871-0-64_1000.jpg";
    }
    else if (material == "Veneer") {
        document.getElementById("material_preview").src = "https://images.homedepot-static.com/productImages/8c98bb3a-1161-4cbf-8a89-abf63e1a4f50/svn/patching-repair-8101050-64_400_compressed.jpg";
    }
}

var click = new Audio();
click.src = "http://faintdev.net/academic/sounds/bg2click.mp3";

function playClick() {
    click.play();
}