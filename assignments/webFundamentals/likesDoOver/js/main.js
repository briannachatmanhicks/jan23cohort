// let likesarr = [parseInt(document.getElementById('likecount').innerText), parseInt(document.getElementById('likecount2').innerText), parseInt(document.getElementById('likecount3').innerText) ]

let likesarr2 = [document.getElementById('likecount'),document.getElementById('likecount2'), document.getElementById('likecount3')]
console.log(likesarr)

// let buttclass = document.getElementsByClassName('likebutt')
// console.log(buttclass)
// console.log('here i am',likesarr[0])


function newLike(i) {
    for (let x=0; x < likesarr2.length; x++){
        // console.log(x)
        if (i == x) {
            let newLikes = parseInt(likesarr2[i].innerText)
            console.log(newLikes)
            newLikes += 1
            likesarr2[i].textContent = newLikes
            // likesarr2[]
        }
    }
}