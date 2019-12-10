/////////////////////
// color in slider //
/////////////////////
const slider = document.getElementById("Tone")
const max = slider.getAttribute("max")
const step = 100 / (max)
let value = slider.value
slider.addEventListener("change", function () {
    value = slider.value
    run()
})
function run() {
    const width = step * (value)
    const style = "linear-gradient(to right, #27928B, #27928B " + width + "%, #EFF7FF " + width + "%, #EFF7FF )"
    slider.style.background = style
    // console.log(style)
}
/////////////////
// tag display //
/////////////////
const tagBox = document.getElementById("tagBox")
const tagInput = document.getElementById("tagsInput")
let tagArray = []

// listen on key press
tagInput.addEventListener("keyup", function (e) {
    // if space key pressed
    if (e.keyCode == 32) {
        // trim spaces from value
        const value = this.value.trim().replace(/[^A-Za-z]/g, '').toLowerCase();
        // empty input's value
        this.value = ""

        let check = keywAr.find(task => task.value === value)

        // check if the tag is unique
        if (tagArray.indexOf(value) === -1 && value !== "" && check) {
            tagArray.push(check.id);

            // create Tag element
            let tagEl = document.createElement("SPAN")
            tagEl.innerText = value
            tagEl.classList.add("tag")
            tagEl.dataset.value = value
            tagEl.dataset.id = check.id

            // target tag and input container
            const tagBox = document.getElementById("tagBox")

            // add tag before last child (input)
            tagBox.insertBefore(tagEl, tagBox.childNodes[tagBox.childNodes.length - 1]);
            // update clickDelete tagInputs array
            clickDelete()
        }
    }
})

// remove last tag if backspace
let tryNumber = 1
tagInput.addEventListener("keyup", function (e) {
    if (e.keyCode == 8 && this.value === "") {
        // prevent deleting tag right away
        tryNumber -= 1;
        if (tryNumber < 0) {
            // get last tag from array
            const lastTag = tagArray[tagArray.length - 1]
            // get last tag element
            const lastTagEl = document.querySelectorAll('.tag[data-id="' + lastTag + '"]')
            // put the last tag text into input
            const tagText = keywAr.find(key => key.id === lastTag)

            tagInput.value = tagText.value
            // remove it
            lastTagEl[0].remove()
            // remove last tag from array
            tagArray.pop()

            // restore try number                    
            tryNumber = 1
            // update clickDelete tagInputs array
            clickDelete()
        }
    }
})

// remove tag on click
function clickDelete() {

    // list of all tags
    let tagInputs = document.querySelectorAll("#tagBox .tag")

    for (const tag of tagInputs) {
        // for each listen for click
        tag.addEventListener("click", function () {
            // get this tag text
            const text = this.dataset.id
            // target it and remove it from array
            const index = tagArray.indexOf(text)
            if (index !== -1) tagArray.splice(index, 1);

            document.getElementById("KeywordIds").value = tagArray.toString()

            // remove from DOM
            this.remove()
        })
    }
    
}

document.getElementById("tagsInput").addEventListener("keyup", function() {
    document.getElementById("KeywordIds").value=tagArray.toString()
});

let keywAr = []
function getListOfKeywords() {
    const options = document.getElementsByTagName("DATALIST")[0].options;
    for (const opt of options) {
        const opti = {
            id: opt.dataset.id,
            value: opt.value
        }
        keywAr.push(opti)
    }
}
getListOfKeywords()