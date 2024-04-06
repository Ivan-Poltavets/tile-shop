import React from 'react';
import Header from "../../components/Header/Header";
import Footer from "../../components/Footer/Footer";
import pageStyles from '../styles/Page.module.css';

const HomePage = () => {
    return (
        <div className={pageStyles.page}>
            <Header/>
            <Footer/>
        </div>
    );
};

export default HomePage;