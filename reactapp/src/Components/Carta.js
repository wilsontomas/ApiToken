import React from 'react'

const Carta = () => {
    return (
        <div>
            <div className="card mr-3" style={{width: '18rem'}}>
            <img className="card-img-top" src='/news.png' />
            <div className="card-body">
                <h5 className="card-title">Card title</h5>
                <p className="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" className="btn btn-primary">Go somewhere</a>
            </div>
            </div>
        </div>
    )
}

export default Carta