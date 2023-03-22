console.log('wiredUp')

console.log(document.getElementsByClassName('likebutt').innerHTML)
let likes = document.getElementById('likecount')
console.log(likes)
function newLike() {
    // console.log(element);
    console.log(document.getElementById('likecount'))
    let newLikes = parseInt (likes.innerText)
    console.log(newLikes)
    newLikes += 1
    likes.textContent= newLikes
    // for (let i =0; i < likes.length; i++) {
    //     let newLikes = parseInt(likes[i].innerText)
    //     newLikes = newLikes + 1
    //     console.log (newLikes)
    //     likes[i].textContent = newLikes
    // }
}

// need to learn how to change each individual function with one function instead of running three different ones. this can be helped with query selector, but I don't understand the concept at this moment.

function newLike2() {
    let likes = document.getElementById('likecount2')
    // console.log(element);
    console.log(document.getElementById('likecount2'))
    let newLikes = parseInt (likes.innerText)
    console.log(newLikes)
    newLikes += 1
    likes.textContent= newLikes
}

function newLike3() {
    let likes = document.getElementById('likecount3')
    // console.log(element);
    console.log(document.getElementById('likecount3'))
    let newLikes = parseInt (likes.innerText)
    console.log(newLikes)
    newLikes += 1
    likes.textContent= newLikes
}