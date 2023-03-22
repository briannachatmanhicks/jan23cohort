console.log('wiredUp')

function likeAlert() {
    alert ('Ninja was liked')
}

function logInOut(){
    let status = document.getElementById('userbutton').innerHTML
    console.log(status)
    if (status === 'Login') {
        // console.log('check')
        status = 'Logout'
        document.getElementById('userbutton').innerHTML = status
        console.log(status)
    }
    else {
        status = 'Login'
        document.getElementById('userbutton').innerHTML = status
    }
}

function dissapear() {
    document.getElementById('define').style.display = 'none'
}