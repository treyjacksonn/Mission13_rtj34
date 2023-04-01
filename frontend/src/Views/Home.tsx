import React from 'react';
import styles from './Home.module.css';

// Home functionality to display photo and website discription
function Home() {
  return (
    <>
      <div className="text-center">
        <h1 className={styles.h1}>Welcome to Joel's Movie Website!</h1>
      </div>
      <div className="row">
        <div className="text-center">
          <h3>
            On this webpage you will find a vast database of all of the classic
            movies recommended by the GOAT, Joel Hilton
          </h3>
          <img src="./JoelHiltonHeadshot.jpg" alt="joelPhoto" />
          <p>A photo of the one and only Joel Hilton</p>
        </div>
      </div>
    </>
  );
}

export default Home;
