import "./Home.css";
import Hilo from "./Hilo";
import React, { useRef, useState, Component, useNavigate } from "react";

function Home() {
  return (
    <div className="row">
      <table className="table table-striped table-bordered table-responsive">
        <thead className="thead-light">
          <tr className="Question">QUESTION</tr>
          <tr>
            <th scope="col" className="forum-col">
              Forum
            </th>
            <th scope="col">Posts</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>
              <h3 className="h5 mb-0">
                <div className="Title">
                  <a className="Name" href="/thread">
                    Nombre del Hilo
                  </a>
                </div>
              </h3>
              <p className="mb-0">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. In
                laoreet pellentesque lorem sed elementum.
              </p>
            </td>
            <td>
              <div className="nmbr">18</div>
            </td>
          </tr>
        </tbody>
        <thead className="thead-light">
          <tr className="Suggestion">SUGGESTION</tr>
          <tr>
            <th scope="col" className="forum-col">
              Forum
            </th>
            <th scope="col">Posts</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>
              <h3 className="h5 mb-0">
                <div className="Title">
                  <a className="text-uppercase" href="/thread">
                    Nombre del Hilo
                  </a>
                </div>
              </h3>
              <p className="mb-0">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. In
                laoreet pellentesque lorem sed elementum.
              </p>
            </td>
            <td>
              <div className="nmbr">18</div>
            </td>
          </tr>
        </tbody>
        <thead className="thead-light">
          <tr className="Clarification">CLARIFICATION</tr>
          <tr>
            <th scope="col" className="forum-col">
              Forum
            </th>
            <th scope="col">Posts</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>
              <h3 className="h5 mb-0">
                <div className="Title">
                  <a className="text-uppercase" href="/thread">
                    Nombre del Hilo
                  </a>
                </div>
              </h3>
              <p className="mb-0">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. In
                laoreet pellentesque lorem sed elementum.
              </p>
            </td>
            <td>
              <div className="nmbr">18</div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  );
}
export default Home;
