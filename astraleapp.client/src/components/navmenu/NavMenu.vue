<script setup lang="ts">
</script>

<template>
<div :class="styles.FrostedBanner">
  <div :class="styles.NavBackground"></div>
  <nav :class="styles.Navbar">
    <a :class="styles.Overwatch">
      Home
    </a>
    <a :class="styles.Sortie">
      Sortie
    </a>
    <a :class="styles.Assembly">
      Garage
    </a>
    <a :class="styles.Mission">
      Mission
    </a>

    <div :class="styles.Line1"></div>
    <div :class="styles.Line2"></div>
    <div :class="styles.Line3"></div>
    <div :class="styles.Line4"></div>
  </nav>
</div>
</template>

<style scoped module="styles" lang="scss">
.FrostedBanner {
  padding: 1rem;
  z-index: auto;

  height: fit-content;
  width: auto;
  opacity: 99%;

  top: 0;
  position: sticky;
  display: inline-block;
}

.NavBackground {
  width: 1350px;
  height: 75px;
  top: calc(100% / 10);
  left: calc(100% / 30);

  backdrop-filter: blur(5.75256333rem);
  background-color: #ecf1f2;
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3E%3Cpath fill='%234065b0' fill-opacity='0.4' d='M1 3h1v1H1V3zm2-2h1v1H3V1z'%3E%3C/path%3E%3C/svg%3E");

  display: inline-flex;
  position: absolute;
  opacity: 9.254333%;
}

.Navbar {
  transition: 1s;
  padding: 2rem;

  font-family: ui-monospace, Menlo, Monaco, 'Cascadia Mono', 'Segoe UI Mono',
    'Roboto Mono', 'Oxygen Mono', 'Ubuntu Monospace', 'Source Code Pro',
    'Fira Mono', 'Droid Sans Mono', 'Courier New', monospace;

  a {
    left: calc(100% / 2.5);
    right: calc(100% / 2.5);
  }

  button {
    float: none;
    border: none;
    outline: none;
    color: #faf9fa;
  
    display: inline;
    position: relative;
    text-decoration: none;
    text-align: center;
    align-items: center;
  
    transition: 1s;
    padding: 0.8rem;
    margin: 0.4rem;
  
    top: 0.25rem;
  
    background-color: rgba(var(--callout-rgb), 0.5);
    border: 1px none rgba(var(--callout-border-rgb), 0.3);
    border-radius: var(--border-radius);
  }
}

.Overwatch {
  position: relative;
  font-size: 14px;
  font-weight: 400;
  word-wrap: break-word;
}

.Mission {
  position: relative;
  font-size: 14px;
  font-weight: 400;
  word-wrap: break-word;
}

.Sortie {
  position: relative;
  font-size: 14px;
  font-weight: 400;
  word-wrap: break-word;
}

.Assembly {
  position: relative;
  color: #f7f9fe;
  font-size: 14px;
  font-weight: 400;
  word-wrap: break-word;
}

.Line1 {
  width: 1385px;
  height: 0px;
  left: -21px;
  top: 0.95256333rem;
  position: relative;
  border: 0.5px #ecf1f2 solid;
}

.Line2 {
  width: 1385px;
  height: 0px;
  left: -20px;
  top: -3.75256333rem;
  position: relative;
  border: 0.5px #ecf1f2 solid;
}

.Line3 {
  width: 110px;
  height: 0px;
  left: 1349px;
  top: -5rem;
  position: relative;
  transform: rotate(90deg);
  transform-origin: 0 0;
  border: 0.5px #ecf1f2 solid;
}

.Line4 {
  width: 110px;
  height: 0px;
  left: -0px;
  top: -5.124rem;
  position: relative;
  transform: rotate(90deg);
  transform-origin: 0 0;
  border: 0.5px #ecf1f2 solid;
}
</style>
