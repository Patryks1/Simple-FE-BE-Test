import React from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { InfButton } from './components/InfButton';

import './custom.css'

const App = () => {
  return (
    <Layout>
      <Route exact path='/' component={Home} />
      <Route exact path='/infi-button' component={InfButton} />
    </Layout>
  );
}

export default App;
