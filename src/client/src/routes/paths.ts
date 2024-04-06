import React from "react";
import HomePage from "../pages/HomePage/HomePage";

interface IRoute{
    path: string;
    Component: React.FC<any>;
}

export const authRoutes: IRoute[] = [
];

export const publicRoutes: IRoute[] = [
    {
        path: '/',
        Component: HomePage
    },
]