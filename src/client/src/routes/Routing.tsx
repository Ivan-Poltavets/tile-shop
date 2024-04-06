import React from 'react';
import {Routes, Route} from "react-router-dom";
import {publicRoutes} from "./paths";

const Routing = () => {
    return (
        <Routes>
            {publicRoutes.map(({path, Component}) =>
                <Route key={path} path={path} element={<Component/>}></Route>)}
        </Routes>
    );
};

export default Routing;