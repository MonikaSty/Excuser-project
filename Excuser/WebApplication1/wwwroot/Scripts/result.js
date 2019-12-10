// Global Scope variable we need this
var clickCount = 0;
// Our Timeout, modify it if you need
var timeout = 500;
// Copy this function and it should work
function clicks(word) {
    // We modify clickCount variable here to check how many clicks there was
    clickCount++;
    if (clickCount == 1) {
        setTimeout(() => {
            if (clickCount == 1) {
                singleClick(word)
            } else {
                doubleClick()
            }
            clickCount = 0;
        }, timeout || 300);
    }
}

// remove list on click anywhere
document.addEventListener("click", function () {
    const list = document.querySelectorAll(".list")
    if (list.length > 0) list[0].remove()
})

// transform all text into spans on init
start()
// init fn
function start() {
    let text = document.getElementById("resultText")
    let textSpans = text.innerText.replace(/([A-Z]*[a-z]*)\w+/g, function (text) {
        return '<span class="textSpan" data-word="' + text + '">' + text + '</span>';
    })
    text.innerHTML = textSpans
    listener()
}
// same fn as start but with text (from edit fn)
function reStart(text) {
    let textSpans = text.replace(/([A-Z]*[a-z]*)\w+/g, function (text) {
        return '<span class="textSpan" data-word="' + text + '">' + text + '</span>';
    })
    document.getElementById("resultText").innerHTML = textSpans
    listener()
}

// adds all listeners to words
function listener() {
    let allSpans = document.querySelectorAll(".textSpan")
    for (const span of allSpans) {
        const word = span.innerText
        span.addEventListener("click", () => { clicks(word) })
    }
}

// removes all the spans and replaces them (removes event listeners)
function cleaner() {
    let allSpans = document.querySelectorAll(".textSpan")
    for (const span of allSpans) {
        const spanClone = span.cloneNode(true)
        span.parentNode.replaceChild(spanClone, span)
    }
    // adds all listeners again to new nodes
    listener()
}

// function on single click
function singleClick(word) {
    // remove list when click on another word
    const list = document.querySelectorAll(".list")
    if (list.length > 0) list[0].remove()

    // gets clicked word and fetches 7 synonyms 
    let text = document.getElementById("resultText")
    const thisWord = document.querySelectorAll('.textSpan[data-word="' + word + '"]')
    fetch("https://api.datamuse.com/words?ml=" + word + "&max=7")
        .then(response => response.json())
        .then(data => {
            // create list element
            const list = document.createElement("DIV")
            list.classList.add("list")
            list.dataset.word = word

            // create edit text button in list
            const editLink = document.createElement("A")
            editLink.addEventListener("click", () => editText())
            editLink.innerHTML = '<span class="icon edit"></span>Edit text'
            list.append(editLink)

            // fill list element with synonyms
            for (const synonym of data) {
                const synEl = document.createElement("SPAN")
                synEl.classList.add("listItem")
                synEl.innerText = synonym.word
                list.append(synEl)
            }


            // inserts list before chosen word
            for (var i = 0; i < text.childNodes.length; i++) {
                if (text.childNodes[i].dataset !== undefined) {
                    if (text.childNodes[i].dataset.word === thisWord[0].innerText) {
                        const that = text.childNodes[i]

                        // position it around the word
                        list.style.top = that.offsetTop + "px"
                        list.style.left = that.offsetLeft + "px"
                        list.addEventListener("mouseleave", () => {
                            document.querySelectorAll(".list")[0].remove()
                        })

                        document.getElementsByTagName("BODY")[0].append(list)
                        listFn()
                    }
                }
            }

        })
}

// function of the list - replaces words with synonyms
function listFn() {
    const spans = document.querySelectorAll(".list .listItem")
    // get the word that is to be replaced
    const listWord = document.getElementsByClassName("list")[0].dataset.word

    // adds on click to each list item
    spans.forEach(element => {
        element.addEventListener("click", function () {
            const thisWord = this.innerText
            let thisEl = document.querySelectorAll('.textSpan[data-word="' + listWord + '"]')
            // replace current word with chosen word
            if (thisEl.length > 0) {
                thisEl[0].innerText = thisWord
                thisEl[0].dataset.word = thisWord
                cleaner()
            }
        })
    });

}

function doubleClick() {
    editText()
}

function editText() {
    // get the whole container
    const resultContainer = document.getElementById("resultText")
    // make sure list is removed
    const list = document.querySelectorAll("#resultText .list")
    if (list.length > 0) list[0].remove()
    // get container's text
    const text = resultContainer.innerText
    // empty container
    resultContainer.innerHTML = ""

    // create sec. container 
    const secCon = document.createElement("DIV")
    secCon.classList.add("editContainer")

    // creating textarea
    const textarea = document.createElement("TEXTAREA")
    textarea.classList.add("editBlock")
    textarea.value = text
    secCon.append(textarea)

    // create save button
    const saveButton = document.createElement("A")
    saveButton.classList.add("button", "rounded", "margintop", "zfix")
    saveButton.innerText = "Save changes"
    saveButton.addEventListener("click", () => saveEdit())
    secCon.append(saveButton)

    // append sec. container
    resultContainer.append(secCon)

    // disable share options
    const noedits = document.getElementsByClassName("noedit")
    for (const noedit of noedits) {
        noedit.classList.add("prevent")
    }

}

function saveEdit() {
    // get edited text
    const text = document.getElementsByClassName("editBlock")[0].value
    // remove textarea
    document.getElementsByClassName("editContainer")[0].remove
    // restart text container
    reStart(text)
    // enable share options
    const noedits = document.getElementsByClassName("noedit")
    for (const noedit of noedits) {
        noedit.classList.remove("prevent")
    }
}

function sendEmail() {
    // get text
    const body = document.getElementById("resultText").innerText

    // send it
    window.location = "mailto:?body=" + body;
    alert("Send your email!")
}

// based on https://techoverflow.net/2018/03/30/copying-strings-to-the-clipboard-using-pure-javascript/

function copyToClipboard() {
    // get inner text of the result
    let str = document.getElementById("resultText").innerText

    // Create new element
    var el = document.createElement('textarea');
    // Set value (string to be copied)
    el.value = str;
    // Set non-editable to avoid focus and move outside of view
    el.setAttribute('readonly', '');
    el.style = { position: 'absolute', left: '-9999px' };
    document.body.appendChild(el);
    // Select text inside element
    el.select();
    // Copy text to clipboard
    document.execCommand('copy');
    // Remove temporary element
    document.body.removeChild(el);
    alert("Excuse copied to clipboard!")

}